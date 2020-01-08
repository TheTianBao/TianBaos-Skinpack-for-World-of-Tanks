Public Class MainForm
#Region "CMD"
    Private Sub CMDChangePath_Click(sender As Object, e As EventArgs) Handles CMDChangePath.Click

    End Sub

    Private Sub CMDCleanFolder_Click(sender As Object, e As EventArgs) Handles CMDCleanFolder.Click

    End Sub

    Private Sub CMDInstallSelected_Click(sender As Object, e As EventArgs) Handles CMDInstallSelected.Click

    End Sub

    Private Sub CMDInstallAll_Click(sender As Object, e As EventArgs) Handles CMDInstallAll.Click

    End Sub

    Private Sub CMDModHub_Click(sender As Object, e As EventArgs) Handles CMDModHub.Click

    End Sub

    Private Sub CMDClan_Click(sender As Object, e As EventArgs) Handles CMDClan.Click

    End Sub

#End Region

#Region "Image Preview"
    'China
    Private Sub CBWZ121BlueStorm_MouseHover(sender As Object, e As EventArgs) Handles CBWZ121BlueStorm.MouseHover
        Me.PictureBox1.Image = My.Resources.WZ121_Front_Blue
        Me.PictureBox2.Image = My.Resources.WZ121_Back_Blue
        Me.PictureBox3.Image = My.Resources.WZ121_Left_Blue
        Me.PictureBox4.Image = My.Resources.WZ121_Right_Blue
    End Sub
    'German
    Private Sub CB88JTGreenTiger_MouseHover(sender As Object, e As EventArgs) Handles CB88JTGreenTiger.MouseHover
        Me.PictureBox1.Image = My.Resources.JT88_Front_Green
        Me.PictureBox2.Image = My.Resources.JT88_Back_Green
        Me.PictureBox3.Image = My.Resources.JT88_Left_Green
        Me.PictureBox4.Image = My.Resources.JT88_Right_Green
    End Sub
#End Region



End Class
