Public Class frmMain
    'Programmer: Cameron Downer
    'Date: 10/4/15
    'This program takes the amount of shingles or roll used and computes the percentage of the whole unit used in decimal form
    'Input: Ft per roll, ft used
    'Output: decimal equivelant 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This button calculates the decimal equivelant of the feet used in a roll

        'Declared Variables
        Dim totalUsed As Decimal 'Percentage of the roll used in decimal form
        Dim feetUsed As Decimal  'Feet of roll used
        Dim feetInRoll As Decimal  'Feet per roll

        'Takes textbox data and places it into the respective variables
        Decimal.TryParse(txtFeetUsed.Text, feetUsed)
        Decimal.TryParse(txtFeetInRoll.Text, feetInRoll)

        'Algorithm:
        'total used = ft used / ft per roll
        totalUsed = feetUsed / feetInRoll

        'Display
        lblTotalUsedOfRoll.Text = totalUsed.ToString("N4")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'This button clears the textboxes and the total box for the Roll calculator
        txtFeetUsed.Text = ""
        txtFeetInRoll.Text = ""
        lblTotalUsedOfRoll.Text = ""
    End Sub

    Private Sub btnSHClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSHClear.Click
        'this button clears the output box for Shingle calculator
        lblTotalUsedOfSquare.Text = ""
    End Sub

    Private Sub btnRLCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRLCalculate.Click
        'This button calculates the decimal equivelant of the shingles used in a square of shingles

        Dim totalUsed As Decimal 'Total used out of a square in decimal form
        Dim shinglesOrBundlesUsed As Decimal 'number of shingles or bundles Used

        Const ShinglesInTimberlineHD As Decimal = 63 '63 shingles per square of GAF Timberline HD
        Const ShinglesInLandmarkPro As Decimal = 66 '66 shingles per square of Certainteed Landmark Pro
        Const ShinglesInLandmark As Decimal = 66 '66 shingles per square of Certainteed Landmark Pro
        Const ShinglesInOakridge As Decimal = 63 '63 shingles per square of Owens Corning Oakridge
        Const ShinglesInSupreme As Decimal = 78 '78 shingles per square of Owens Corning Supreme

        Const BUNDLESINSQUARE As Decimal = 3 '3 Bundles of shingles in a square

        'link textbox with variable
        Decimal.TryParse(txtShinglesOrBundlesUsed.Text, shinglesOrBundlesUsed)


        Select Case True
            Case radShingle.Checked
                If radTimberlineHD.Checked Then
                    totalUsed = shinglesOrBundlesUsed / ShinglesInTimberlineHD
                ElseIf radLandmark.Checked Then
                    totalUsed = shinglesOrBundlesUsed / ShinglesInLandmark
                ElseIf radLandmarkPro.Checked Then
                    totalUsed = shinglesOrBundlesUsed / ShinglesInLandmarkPro
                ElseIf radOakridge.Checked Then
                    totalUsed = shinglesOrBundlesUsed / ShinglesInOakridge
                ElseIf radSupreme.Checked Then
                    totalUsed = shinglesOrBundlesUsed / ShinglesInSupreme
                End If
            Case radBundle.Checked
                If radTimberlineHD.Checked Then
                    totalUsed = shinglesOrBundlesUsed / BUNDLESINSQUARE
                ElseIf radLandmark.Checked Then
                    totalUsed = shinglesOrBundlesUsed / BUNDLESINSQUARE
                ElseIf radLandmarkPro.Checked Then
                    totalUsed = shinglesOrBundlesUsed / BUNDLESINSQUARE
                ElseIf radOakridge.Checked Then
                    totalUsed = shinglesOrBundlesUsed / BUNDLESINSQUARE
                ElseIf radSupreme.Checked Then
                    totalUsed = shinglesOrBundlesUsed / BUNDLESINSQUARE
                End If
        End Select

        'Display
        lblTotalUsedOfSquare.Text = totalUsed



    End Sub
End Class
