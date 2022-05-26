Imports System.Data.OleDb

Public Class FRM_MANAGE_ORDERS
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As New DataTable
    Public Uname As String


    Sub FilDGV()
        dt.Clear()
        Dim strQury As String = "select Orders.ID , Orders.OrderDate , Orders.Salesman ,Orders.Des  , Customers.FullName , Orders.total , Orders.dd ,Orders.bb ,Orders.dess,count(Order_Detils.ID_Product),sum(Order_Detils.Qty) From Orders, Order_Detils ,Customers where  Orders.ID = Order_Detils.ID_Order and Orders.IDCustomres = Customers.ID group by Orders.ID , Orders.OrderDate , Orders.Salesman ,Orders.Des , Customers.FullName , Orders.total , Orders.dd ,Orders.bb ,Orders.dess"
        adapter = New OleDbDataAdapter(strQury, con)
        
        adapter.Fill(dt)
        Me.dgvORders.DataSource = dt
        dgvORders.Columns(0).HeaderText = "رقم الفاتورة"
        dgvORders.Columns(1).HeaderText = "تاريخ البيع"
        dgvORders.Columns(2).HeaderText = "البائع"
        dgvORders.Columns(3).HeaderText = "الوصف"
        dgvORders.Columns(4).HeaderText = "العميل"
        dgvORders.Columns(5).HeaderText = "الاجمالي"
        dgvORders.Columns(6).HeaderText = "المدفوع"
        dgvORders.Columns(7).HeaderText = "الباقي"
        dgvORders.Columns(8).HeaderText = "الخصم"
        dgvORders.Columns(9).HeaderText = "عدد الاصناف"
        dgvORders.Columns(10).HeaderText = "عدد القطع"
        dgvORders.Columns(0).Width = 55
        dgvORders.Columns(1).Width = 100
        dgvORders.Columns(2).Width = 55
        dgvORders.Columns(3).Width = 55
        dgvORders.Columns(4).Width = 70
        dgvORders.Columns(5).Width = 55
        dgvORders.Columns(6).Width = 55
        dgvORders.Columns(7).Width = 55
        dgvORders.Columns(8).Width = 55
        dgvORders.Columns(9).Width = 55
        dgvORders.Columns(10).Width = 55

    End Sub
    Private Sub FRM_MANAGE_ORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New FRM_ORDERS
        frm.Text = "اضافة فاتورة جديدة"
        frm.TextBox1.Text = Uname
        frm.btnSave.Text = "حفظ الفاتورة"
        frm.state = "add"
        frm.ShowDialog()
        FilDGV()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New FRM_ORDERS

        frm.Text = "تعديل الفاتورة:" & dgvORders.CurrentRow.Cells(0).Value
        frm.btnSave.Text = "حفظ التعديل"
        frm.txt_Date.Text = Me.dgvORders.CurrentRow.Cells(1).Value
        frm.TextBox1.Text = Me.dgvORders.CurrentRow.Cells(2).Value
        frm.txtDes.Text = Me.dgvORders.CurrentRow.Cells(3).Value
        frm.txt_total.Text = Me.dgvORders.CurrentRow.Cells(5).Value
        frm.txt_d.Text = Me.dgvORders.CurrentRow.Cells(6).Value
        frm.txt_b.Text = Me.dgvORders.CurrentRow.Cells(7).Value
        cmd = New OleDbCommand("select * from Customers , Orders where Customers.ID = Orders.IDCustomres and Orders.ID = " & dgvORders.CurrentRow.Cells(0).Value, con)
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        frm.txtCustId.Text = dr(0)
        frm.txtFullName.Text = dr(1)
        frm.txtTel.Text = dr(2)
        dr.Close()
        con.Close()
        adapter = New OleDbDataAdapter("select Product.Code , Product.NameProduct, Order_Detils.Qty, Order_Detils.Price, Order_Detils.Amount ,Order_Detils.Qty_in from Product ,Order_Detils where Product.code = Order_Detils.ID_Product and Order_Detils.ID_Order = " & dgvORders.CurrentRow.Cells(0).Value, con)

        adapter.Fill(frm.dt)
        frm.dgvProduct.DataSource = frm.dt
        frm.state = "Edit"
        frm.IDOrder = dgvORders.CurrentRow.Cells(0).Value
        frm.ShowDialog()
        FilDGV()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

   
End Class