

Public Class Form2
    Public opcao As String

    Private Sub Limpar()
        Tdesc.Text = ""
        Tmarc.Text = "'"
        Tano.Text = ""
        Tmodelo.Text = ""
        Tcor.Text = ""
        Tcategoria.Text = ""
        dispbox.SelectedIndex = -1
    End Sub
    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexao As New OleDb.OleDbConnection

        Dim d, m, a, ml, c, cat, disp As String

        conexao.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VoceAluga\banco.accdb"
        conexao.Open()

        d = Tdesc.Text
        m = Tmarc.Text
        a = Tano.Text
        ml = Tmodelo.Text
        c = Tcor.Text
        cat = Tcategoria.Text

        If dispbox.SelectedIndex <> "-1" Then
            If dispbox.SelectedIndex = "0" Then
                disp = "SIM"
            Else
                disp = "NAO"
            End If

        End If


        Dim Cmd As New OleDb.OleDbCommand
        Cmd.Connection = conexao
        If opcao = 1 Then
            Cmd.CommandText = "INSERT INTO Carros(Descricao, Marca, Ano, Modelo, Cor, Categoria, Disponivel )VALUES(@d,@m,@a,@ml,@c,@Cat,@disp)"
            '"INSERT INTO Carros(Descricao, Marca,Ano,Modelo,Cor,Categoria)
            '  " VALUES( '" & Tdesc.Text & "'," & Tmarc.Text & "'," & Tano.Text & "'," & Tmodelo.Text & "'," & Tcor.Text & "'," & Tcategoria.Text & ")"

        Else
            Cmd.CommandText = "Update Carros SET Descricao = '" & d & "', Marca = '" & m & "', Ano = '" & a & "', Modelo = '" & ml & "', Cor = '" & c & "', Disponivel = '" & disp & "', Categoria = '" & cat & "'" & _
                " WHERE codigo =" & TextBox7.Text

        End If
        Cmd.Parameters.Add("@d", OleDb.OleDbType.VarChar).Value = d
        Cmd.Parameters.Add("@M", OleDb.OleDbType.VarChar).Value = m
        Cmd.Parameters.Add("@a", OleDb.OleDbType.VarChar).Value = a
        Cmd.Parameters.Add("@ml", OleDb.OleDbType.VarChar).Value = ml
        Cmd.Parameters.Add("@c", OleDb.OleDbType.VarChar).Value = c
        Cmd.Parameters.Add("@cat", OleDb.OleDbType.VarChar).Value = cat
        Cmd.Parameters.Add("@Disp", OleDb.OleDbType.VarChar).Value = disp

        Cmd.ExecuteNonQuery()
        MsgBox("Dados Salvos com sucesso!")
        opcao = 3
        Limpar()
        conexao.Close()
        Form1.CarregaDados()
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Limpar()
        Close()
    End Sub

    Private Sub Tano_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tano.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub Tmodelo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tmodelo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If

    End Sub
End Class