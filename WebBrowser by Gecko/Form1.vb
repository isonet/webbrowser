''' <summary>
''' </summary>
''' <remarks>
''' Zum besseren Gliedern:
'''     #Region "TeST"
'''     #End Region
''' 
''' ToDo:
'''      -AJAX loading GIF
'''      -Contextmenustrip im Webkitbrowser
''' </remarks>






Public Class Form1

    Dim current_tab As Integer = 0    'Variable die anzeigt welcher Tab gerade aktuell ist (startet bei 0)
    Dim mouse_down As Boolean = False 'Gehört zu dem Versuch die Browserbar verändern zu können

    '' Bei Enter in der Combobox navigieren
    Private Sub ToolStripComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ts_cbURL.KeyDown

        If e.KeyValue = 13 Then
            ts_cbURL.Items.Add(ts_cbURL.Text)
            CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).Navigate(ts_cbURL.Text)
        End If

    End Sub
    ''/Bei Enter in der Combobox navigieren

    '' Funktion zum Hinzufügen eines neuen Tabs
    Public Function wb_add_tab(Optional ByVal form_load As Boolean = False, Optional ByVal url As String = "http://www.google.de")

        'Erstellen des WB ANFANG
        Dim new_wb As New WebKit.WebKitBrowser
        With new_wb
            .Dock = DockStyle.Fill
            .Visible = True
            .Name = "wb_tab_" & (Panel2.Controls.Count + 1)
            .Text = "wb " & (Panel2.Controls.Count + 1)
            .DocumentText = Panel2.Controls.Count + 1
            .Url = New Uri(url)
            .AllowNewWindows = True
            .ContextMenuStrip = cms_wb
        End With

        Panel2.Controls.Add(new_wb)
        AddHandler (new_wb.Navigated), AddressOf tab_wb_navigated
        AddHandler (new_wb.NewWindowRequest), AddressOf tab_wb_new
        'Erstellen des WB ENDE

        'Erstellen des Buttons ANFANG
        Dim new_btn As New Button

        With new_btn
            .AutoSize = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Standard
            .Height = 21
            .Width = 52
            If form_load Then
                .BackColor = Color.Red
            Else
                .BackColor = Color.Transparent
            End If
            .Name = "btn_tab_" & (Panel1.Controls.Count + 1)
            .Text = "Tab " & (Panel1.Controls.Count + 1)
            .Location = New System.Drawing.Point(52 * Panel1.Controls.Count + 1)
        End With

        Panel1.Controls.Add(new_btn)
        AddHandler (new_btn.Click), AddressOf tab_btn_click
        'Erstellen des Buttons ENDE

        If form_load Then

            CType(Panel2.Controls("wb_tab_1"), WebKit.WebKitBrowser).Select()
        Else
            On Error Resume Next
            Panel2.Controls.Item(current_tab).Visible = False
            Panel1.Controls.Item(current_tab).BackColor = Color.Transparent
            Panel2.Controls.Item(Panel2.Controls.Count - 1).Visible = True
            Panel1.Controls.Item(Panel2.Controls.Count - 1).BackColor = Color.Red
            current_tab = Panel2.Controls.Count - 1
            ts_cbURL.Text = CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).Url.AbsoluteUri
            Panel2.Controls.Item(current_tab).Focus()
        End If

        Return True
    End Function
    ''/Funktion zum Hinzufügen eines neuen Tabs

    '' Hinzufügen eines Tabs beim Laden der Form und Anpassen bestimmter Objektgrößen
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ts_cbURL.Width = Me.Width - 200
        line_head.Width = Me.Width
        line_head_2.Width = Me.Width
        Panel1.Width = Me.Width - 16
        Panel2.Width = Me.Width - 16

        wb_add_tab(True)

    End Sub
    ''/Hinzufügen eines Tabs beim Laden der Form und Anpassen bestimmter Objektgrößen

    '' Anpassen bestimmter Objektgrößen und -positionen beim Verändern der Formgröße
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ts_cbURL.Width = Me.Width - 200
        line_head.Width = Me.Width
        line_head_2.Width = Me.Width

        Panel1.Width = Me.Width - 16
        Panel2.Width = Me.Width - 16
        Panel2.Height = Me.Height - (ms_head.Height + ts.Height + ss.Height + Panel1.Height + 39)
        Panel2.Location = New System.Drawing.Point(0, (ms_head.Height + ts.Height + Panel1.Height + 2))

    End Sub
    ''/Anpassen bestimmter Objektgrößen und -positionen beim Verändern der Formgröße

    '' Bei Klick in Scrolldownbox der Combobox navigieren
    Private Sub ts_cbURL_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ts_cbURL.SelectedIndexChanged

        CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).Navigate(ts_cbURL.Items.Item(ts_cbURL.SelectedIndex))

    End Sub
    ''/Bei Klick in Scrolldownbox der Combobox navigieren

    '' Hinzufügen eines Tabs bei Klick auf den Button +
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        wb_add_tab(False)

    End Sub
    ''/Hinzufügen eines Tabs bei Klick auf den Button +

    '' Aktivieren eines Tabs bei Klick auf den passenden Button
    Private Sub tab_btn_click(ByVal sender As Object, ByVal e As System.EventArgs)

        On Error Resume Next
        Dim von_splitted As Array = sender.ToString.Split("Tab")
        Dim von As String = von_splitted(2).ToString.Replace("ab ", "")
        Dim von_int As Integer = Convert.ToInt32(von)
        von_int = von_int - 1
        Panel2.Controls.Item(current_tab).Visible = False
        Panel1.Controls.Item(current_tab).BackColor = Color.Transparent
        Panel2.Controls.Item(von_int).Visible = True
        Panel1.Controls.Item(von_int).BackColor = Color.Red
        current_tab = von_int
        ts_cbURL.Text = CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).Url.AbsoluteUri
        Panel2.Controls.Item(current_tab).Focus()

    End Sub
    ''/Aktivieren eines Tabs bei Klick auf den passenden Button

    '' Aktualisieren der URL in der Combobox
    Private Sub tab_wb_navigated(ByVal sender As Object, ByVal e As System.EventArgs)

        ts_cbURL.Text = CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).Url.AbsoluteUri

    End Sub
    ''/Aktualisieren der URL in der Combobox

    '' Code der Ausgeführt wird nach dem Request eines neuen Fensters
    Private Sub tab_wb_new(ByVal sender As Object, ByVal e As WebKit.NewWindowRequestEventArgs)

        wb_add_tab(False, e.Url)

    End Sub
    ''/Code der Ausgeführt wird nach dem Request eines neuen Fensters

    '' Keine Lust die alle jetzt noch zu kommentieren ;D
#Region "Einfache Codesnippets"

    Private Sub ts_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ts.MouseDown
        mouse_down = True
    End Sub

    Private Sub ts_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ts.MouseMove
        If mouse_down Then
        End If
    End Sub

    Private Sub ts_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ts.MouseUp
        mouse_down = False
    End Sub

    Private Sub tsb_backward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_backward.Click

        ts_cbURL.Text = CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).GoBack

    End Sub

    Private Sub tsb_forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_forward.Click

        ts_cbURL.Text = CType(Panel2.Controls("wb_tab_" & current_tab + 1), WebKit.WebKitBrowser).GoForward

    End Sub


    Private Sub OpenNewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenNewTabToolStripMenuItem.Click
        MsgBox("test")
    End Sub

#End Region
    ''/Keine Lust die alle jetzt noch zu kommentieren ;D

End Class
