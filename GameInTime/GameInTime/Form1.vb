Public Class Form1
    Private Property pageready As Boolean = False
#Region "Page Loading Functions"
    Private Sub WaitForPageLoad()
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    
    Private Sub UbuntuTheme1_Click(sender As Object, e As EventArgs) Handles UbuntuTheme1.Click
        
    End Sub
    Private Sub FindMyString()
        ' Ensure we have a proper string to search for.
        If UbuntuTextBox1.Text <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = ListBox2.FindString(UbuntuTextBox1.Text)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                ListBox2.SetSelected(index, True)
            Else
                MessageBox.Show("The search string did not match any items in the ListBox")
            End If
        End If
    End Sub
   
    Dim items() As String = {}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate("https://thepiratebay.org/top/401")
        WaitForPageLoad()
        For Each elem As HtmlElement In WebBrowser1.Document.All
            If elem.GetAttribute("title").Contains("Λεπτομέρειες για") Then

                ListBox3.Items.Add(elem.GetAttribute("innerText"))
                ListBox2.Items.Add(elem.GetAttribute("innerText"))
                ReDim Preserve items(items.Length)
                items(items.Length - 1) = elem.GetAttribute("innerText")


            End If
        Next
        For Each elem As HtmlElement In WebBrowser1.Document.All
            If elem.GetAttribute("title").Contains("Download this torrent using magnet") Then


                ListBox1.Items.Add(elem.GetAttribute("href"))


            End If
        Next
    End Sub

    Private Sub UbuntuButtonOrange1_Click(sender As Object, e As EventArgs) Handles UbuntuButtonOrange1.Click

        If (ListBox2.SelectedItem <> "") Then
            Label1.Text = ListBox2.SelectedItem.ToString
            For x As Integer = 0 To ListBox3.Items.Count - 1

                If ListBox3.Items(x).ToString = ListBox2.SelectedItem.ToString Then
                    ListBox3.SelectedIndex = x
                End If
            Next
            ListBox1.SetSelected(ListBox3.SelectedIndex, True)
            MessageBox.Show("Επιλέξατε: " & ListBox2.SelectedItem, "Pirate Bay", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            WebBrowser1.Navigate(ListBox1.SelectedItem)
        Else
            MessageBox.Show("You must select an item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UbuntuButtonOrange2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub UbuntuTextBox1_Click(sender As Object, e As EventArgs) Handles UbuntuTextBox1.Click

    End Sub

    Private Sub UbuntuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles UbuntuTextBox1.TextChanged
        If UbuntuTextBox1.Text = "" Then
            ListBox2.Items.Clear()
            ListBox2.Items.AddRange(ListBox3.Items)

        End If

        If ListBox2.Items.Count = 0 Then
            ListBox2.Items.AddRange(ListBox3.Items)
        End If

        Dim items = From it In ListBox2.Items.Cast(Of Object)()
                Where it.ToString().IndexOf(UbuntuTextBox1.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        ListBox2.BeginUpdate()
        ListBox2.Items.Clear()
        For Each item In matchingItemList
            ListBox2.Items.Add(item)
        Next
        ListBox2.EndUpdate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = ProgressBar1.Value & "%" & " Proccessed."
        PictureBox2.Width = CInt(ProgressBar1.Value * 3.79)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PictureBox2.Visible = True
        Panel3.Visible = True
        Timer1.Start()
    End Sub
End Class