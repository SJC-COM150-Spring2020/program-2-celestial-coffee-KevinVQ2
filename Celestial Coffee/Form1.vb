Public Class Form1




    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare regular, decaf, total as double and TAX As Const and calculate Total Price
        Dim Decaf, Regular, Total As Double
        Decaf = CDbl(txtDecaf.Text * 2.0)
        Regular = CDbl(txtRegular.Text * 2.5)
        Const TAX As Double = 0.08875
        Total = CDbl(((Decaf + Regular) * TAX) + (Regular + Decaf))
        txtTotalPrice.Text = FormatCurrency(Total, 2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lstConfirm.Items.Add(txtName.Text & " " & txtAddress.Text & " " & txtCity.Text & " " & txtState.Text & " " & txtZip.Text)
    End Sub


End Class
