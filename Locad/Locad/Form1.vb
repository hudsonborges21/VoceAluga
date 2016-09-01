Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancoDataSet.Carros' table. You can move, or remove it, as needed.
        Me.CarrosTableAdapter.Fill(Me.BancoDataSet.Carros)
        'TODO: This line of code loads data into the 'BancoDataSet.Carros' table. You can move, or remove it, as needed.
        Me.CarrosTableAdapter.Fill(Me.BancoDataSet.Carros)
        'TODO: This line of code loads data into the 'BancoDataSet.Carros' table. You can move, or remove it, as needed.
        Me.CarrosTableAdapter.Fill(Me.BancoDataSet.Carros)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.opcao = 1
        Form2.ShowDialog()
    End Sub


    Public Sub CarregaDados()
        Dim x As String
        'Dim conexao As New OleDb.OleDbConnection
        X = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VoceAluga\banco.accdb"
        'conexao.Open()



        'Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM  Carros order by Descricao", conexao)
        'Dim dt As New DataTable
        'da.Fill(dt)

        'If dt.Rows.Count > 0 Then

        '    DGVcarro.DataSource = dt

        'Else
        '    MsgBox("Registro não localizado")
        'End If

        'conexao.Close()

        ' Instancia objetos dataadapter e connection de forma dinâmica via interface
        Dim da As System.Data.IDbDataAdapter
        Dim cn As System.Data.IDbConnection = GetConnection()


        'verifica se a conexão esta vazia
        If Not IsNothing(cn) Then
            'da = GetDataAdapter(cn)
        Else
            MsgBox("A conexão esta vazia !")
            Exit Sub
        End If

    End Sub


    Private Function GetConnection() As System.Data.IDbConnection

        Return New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VoceAluga\banco.accdb")
        'ElseIf cboTipoBD.SelectedItem = "MSDE" Then
        '    Return New System.Data.SqlClient.SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master;Data Source=MACORATI\VSDOTNET")
        'ElseIf cboTipoBD.SelectedItem = "MySql" Then
        '    Return New MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;password=mac;database=northwind")
        'ElseIf cboTipoBD.SelectedItem = "FireBird" Then
        '    Return New FirebirdSql.Data.Firebird.FbConnection("User=SYSDBA;Password=masterkey;Database=d:\teste\cadastro.gdb;DataSource=localhost;Port=3050;Dialect=3;")

    End Function

    Public Function GetDataAdapter(ByRef cn As System.Data.IDbConnection) As System.Data.IDbDataAdapter

        Dim sql As String

        'If cboTipoBD.SelectedItem = "Access" Then
        sql = "SELECT * FROM  Carros order by Descricao"
        Return New System.Data.OleDb.OleDbDataAdapter(sql, cn)



    End Function
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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.TextBox7.Text = DGVcarro.CurrentRow.Cells(0).Value
        Form2.Tdesc.Text = DGVcarro.CurrentRow.Cells(1).Value
        Form2.Tmarc.Text = DGVcarro.CurrentRow.Cells(2).Value
        Form2.Tano.Text = DGVcarro.CurrentRow.Cells(3).Value
        Form2.Tmodelo.Text = DGVcarro.CurrentRow.Cells(4).Value
        Form2.Tcor.Text = DGVcarro.CurrentRow.Cells(5).Value
        Form2.Tcategoria.Text = DGVcarro.CurrentRow.Cells(6).Value
        If Not IsDBNull(DGVcarro.CurrentRow.Cells(7).Value) Then
            If DGVcarro.CurrentRow.Cells(7).Value = "SIM" Then
                Form2.dispbox.SelectedIndex = 0
            Else
                Form2.dispbox.SelectedIndex = 1
            End If
        Else
            Form2.dispbox.SelectedIndex = 1
        End If


        Form2.opcao = 2
        Form2.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox("Deseja Excluir o registro?", MsgBoxStyle.YesNo) = vbYes Then
            Dim conexao As New OleDb.OleDbConnection
            conexao.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VoceAluga\banco.accdb"
            conexao.Open()
            Dim Cmd As New OleDb.OleDbCommand
            Cmd.Connection = conexao

            Cmd.CommandText = "Delete from Carros WHERE codigo =" & DGVcarro.CurrentRow.Cells(0).Value

            Cmd.ExecuteNonQuery()
            MsgBox("Registro Excluido com sucesso!")

            CarregaDados()
            conexao.Close()
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim DISPONIVEL As String
        DISPONIVEL = PBOX.SelectedIndex

        Dim condicao As String
        condicao = ""

        If PDesc.Text <> "" Then
            condicao = " and Descricao like'%" & PDesc.Text & "%'"
        End If

        If Pmarc.Text <> "" Then
            condicao = condicao & " and Marca like '%" & Pmarc.Text & "%'"
        End If

        If PAno.Text <> "" Then
            condicao = condicao & " and Ano ='" & PAno.Text & "'"
        End If
        If PMol.Text <> "" Then
            condicao = condicao & " and Modelo ='" & PMol.Text & "'"
        End If

        If PCor.Text <> "" Then
            condicao = condicao & " and Cor LIKE'%" & PCor.Text & "%'"
        End If

        If DISPONIVEL <> "-1" Then
            If DISPONIVEL = "0" Then
                condicao = condicao & " and Disponivel LIKE'%" & "SIM" & "%'"
            Else
                condicao = condicao & " and Disponivel LIKE'%" & "NAO" & "%'"
            End If

        End If
        'If Pdisp.Text <> "" Then
        '    condicao = condicao & " and Disponivel LIKE'%" & Pdisp.Text & "%'"
        'End If

        Dim conexao As New OleDb.OleDbConnection
        conexao.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VoceAluga\banco.accdb"
        conexao.Open()


        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Carros where true " & condicao, conexao)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            DGVcarro.DataSource = dt

        Else
            MsgBox("Registro não localizado")
        End If

        conexao.Close()


    End Sub


    Private Sub PAno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub PMol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PMol.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class
