<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblqtdBaixado = New System.Windows.Forms.Label()
        Me.lblProgresso = New System.Windows.Forms.Label()
        Me.pgProgresso = New System.Windows.Forms.ProgressBar()
        Me.txt_URL = New System.Windows.Forms.TextBox()
        Me.Btn_baixar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.FDB = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_valor
        '
        Me.txt_valor.AccessibleDescription = "Usado apenas para referenciar o valor do FDB"
        Me.txt_valor.Location = New System.Drawing.Point(1, 351)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(24, 23)
        Me.txt_valor.TabIndex = 34
        Me.txt_valor.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(669, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(79, 166)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PlaceholderText = "Nome do arquivo"
        Me.txt_nome.Size = New System.Drawing.Size(421, 23)
        Me.txt_nome.TabIndex = 32
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.Location = New System.Drawing.Point(617, 270)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(62, 15)
        Me.lblTam.TabIndex = 31
        Me.lblTam.Text = "Tamanho: "
        '
        'lblqtdBaixado
        '
        Me.lblqtdBaixado.AutoSize = True
        Me.lblqtdBaixado.Location = New System.Drawing.Point(379, 270)
        Me.lblqtdBaixado.Name = "lblqtdBaixado"
        Me.lblqtdBaixado.Size = New System.Drawing.Size(57, 15)
        Me.lblqtdBaixado.TabIndex = 30
        Me.lblqtdBaixado.Text = "Baixados:"
        '
        'lblProgresso
        '
        Me.lblProgresso.AutoSize = True
        Me.lblProgresso.Location = New System.Drawing.Point(79, 270)
        Me.lblProgresso.Name = "lblProgresso"
        Me.lblProgresso.Size = New System.Drawing.Size(62, 15)
        Me.lblProgresso.TabIndex = 29
        Me.lblProgresso.Text = "Progresso:"
        '
        'pgProgresso
        '
        Me.pgProgresso.Location = New System.Drawing.Point(79, 288)
        Me.pgProgresso.Name = "pgProgresso"
        Me.pgProgresso.Size = New System.Drawing.Size(649, 23)
        Me.pgProgresso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgProgresso.TabIndex = 28
        '
        'txt_URL
        '
        Me.txt_URL.Location = New System.Drawing.Point(79, 137)
        Me.txt_URL.Name = "txt_URL"
        Me.txt_URL.PlaceholderText = "URL do arquivo"
        Me.txt_URL.Size = New System.Drawing.Size(421, 23)
        Me.txt_URL.TabIndex = 27
        '
        'Btn_baixar
        '
        Me.Btn_baixar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_baixar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_baixar.Location = New System.Drawing.Point(596, 137)
        Me.Btn_baixar.Name = "Btn_baixar"
        Me.Btn_baixar.Size = New System.Drawing.Size(132, 52)
        Me.Btn_baixar.TabIndex = 26
        Me.Btn_baixar.Text = "Download"
        Me.Btn_baixar.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label1.Font = New System.Drawing.Font("Tahoma", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(348, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(292, 33)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Downloader de .exe "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 374)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lblTam)
        Me.Controls.Add(Me.lblqtdBaixado)
        Me.Controls.Add(Me.lblProgresso)
        Me.Controls.Add(Me.pgProgresso)
        Me.Controls.Add(Me.txt_URL)
        Me.Controls.Add(Me.Btn_baixar)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_valor As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents txt_nome As TextBox
    Private WithEvents lblTam As Label
    Private WithEvents lblqtdBaixado As Label
    Private WithEvents lblProgresso As Label
    Private WithEvents pgProgresso As ProgressBar
    Private WithEvents txt_URL As TextBox
    Private WithEvents Btn_baixar As Button
    Private WithEvents label1 As Label
    Friend WithEvents FDB As FolderBrowserDialog
End Class
