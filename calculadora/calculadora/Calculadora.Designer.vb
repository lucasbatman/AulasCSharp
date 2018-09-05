<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculadora))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.BtnDois = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnAQuatro = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnUm = New System.Windows.Forms.Button()
        Me.btnSete = New System.Windows.Forms.Button()
        Me.btnOito = New System.Windows.Forms.Button()
        Me.btnNove = New System.Windows.Forms.Button()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnPonto = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Super Calculadora 3000"
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(61, 213)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(36, 32)
        Me.btnZero.TabIndex = 1
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'BtnDois
        '
        Me.BtnDois.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDois.Location = New System.Drawing.Point(61, 175)
        Me.BtnDois.Name = "BtnDois"
        Me.BtnDois.Size = New System.Drawing.Size(36, 32)
        Me.BtnDois.TabIndex = 2
        Me.BtnDois.Text = "2"
        Me.BtnDois.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(112, 137)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(36, 32)
        Me.btnSeis.TabIndex = 3
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(61, 137)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(36, 32)
        Me.btnCinco.TabIndex = 4
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnAQuatro
        '
        Me.btnAQuatro.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAQuatro.Location = New System.Drawing.Point(8, 137)
        Me.btnAQuatro.Name = "btnAQuatro"
        Me.btnAQuatro.Size = New System.Drawing.Size(36, 32)
        Me.btnAQuatro.TabIndex = 5
        Me.btnAQuatro.Text = "4"
        Me.btnAQuatro.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(112, 175)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(36, 32)
        Me.btnTres.TabIndex = 6
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnUm
        '
        Me.btnUm.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUm.Location = New System.Drawing.Point(8, 175)
        Me.btnUm.Name = "btnUm"
        Me.btnUm.Size = New System.Drawing.Size(36, 32)
        Me.btnUm.TabIndex = 7
        Me.btnUm.Text = "1"
        Me.btnUm.UseVisualStyleBackColor = True
        '
        'btnSete
        '
        Me.btnSete.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSete.Location = New System.Drawing.Point(8, 99)
        Me.btnSete.Name = "btnSete"
        Me.btnSete.Size = New System.Drawing.Size(36, 32)
        Me.btnSete.TabIndex = 10
        Me.btnSete.Text = "7"
        Me.btnSete.UseVisualStyleBackColor = True
        '
        'btnOito
        '
        Me.btnOito.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOito.Location = New System.Drawing.Point(61, 99)
        Me.btnOito.Name = "btnOito"
        Me.btnOito.Size = New System.Drawing.Size(36, 32)
        Me.btnOito.TabIndex = 9
        Me.btnOito.Text = "8"
        Me.btnOito.UseVisualStyleBackColor = True
        '
        'btnNove
        '
        Me.btnNove.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNove.Location = New System.Drawing.Point(112, 99)
        Me.btnNove.Name = "btnNove"
        Me.btnNove.Size = New System.Drawing.Size(36, 32)
        Me.btnNove.TabIndex = 8
        Me.btnNove.Text = "9"
        Me.btnNove.UseVisualStyleBackColor = True
        '
        'btnSomar
        '
        Me.btnSomar.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSomar.Location = New System.Drawing.Point(164, 99)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(36, 32)
        Me.btnSomar.TabIndex = 13
        Me.btnSomar.Text = "+"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(164, 175)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(36, 32)
        Me.btnDividir.TabIndex = 12
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrair.Location = New System.Drawing.Point(164, 137)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(36, 32)
        Me.btnSubtrair.TabIndex = 11
        Me.btnSubtrair.Text = "-"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(164, 213)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(36, 32)
        Me.btnMultiplicar.TabIndex = 14
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnPonto
        '
        Me.btnPonto.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPonto.Location = New System.Drawing.Point(112, 213)
        Me.btnPonto.Name = "btnPonto"
        Me.btnPonto.Size = New System.Drawing.Size(36, 32)
        Me.btnPonto.TabIndex = 15
        Me.btnPonto.Text = "."
        Me.btnPonto.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(206, 99)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(84, 70)
        Me.btnIgual.TabIndex = 16
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(8, 55)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(282, 38)
        Me.txtResultado.TabIndex = 17
        Me.txtResultado.Text = "0,00"
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(206, 175)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(84, 70)
        Me.btnLimpar.TabIndex = 18
        Me.btnLimpar.Text = "c"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 254)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnPonto)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnSubtrair)
        Me.Controls.Add(Me.btnSete)
        Me.Controls.Add(Me.btnOito)
        Me.Controls.Add(Me.btnNove)
        Me.Controls.Add(Me.btnUm)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnAQuatro)
        Me.Controls.Add(Me.btnCinco)
        Me.Controls.Add(Me.btnSeis)
        Me.Controls.Add(Me.BtnDois)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnZero As Button
    Friend WithEvents BtnDois As Button
    Friend WithEvents btnSeis As Button
    Friend WithEvents btnCinco As Button
    Friend WithEvents btnAQuatro As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents btnUm As Button
    Friend WithEvents btnSete As Button
    Friend WithEvents btnOito As Button
    Friend WithEvents btnNove As Button
    Friend WithEvents btnSomar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnPonto As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnLimpar As Button
End Class
