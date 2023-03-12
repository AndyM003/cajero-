<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRetirar = New System.Windows.Forms.Button()
        Me.ButtonDepositar = New System.Windows.Forms.Button()
        Me.ButtonCambiodeusuario = New System.Windows.Forms.Button()
        Me.ButtonContraseña = New System.Windows.Forms.Button()
        Me.ButtonSaldo = New System.Windows.Forms.Button()
        Me.ButtonMovimientos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(194, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvendo al Menú"
        '
        'ButtonRetirar
        '
        Me.ButtonRetirar.BackColor = System.Drawing.Color.Gray
        Me.ButtonRetirar.Location = New System.Drawing.Point(29, 66)
        Me.ButtonRetirar.Name = "ButtonRetirar"
        Me.ButtonRetirar.Size = New System.Drawing.Size(292, 61)
        Me.ButtonRetirar.TabIndex = 1
        Me.ButtonRetirar.Text = "RETIRAR"
        Me.ButtonRetirar.UseVisualStyleBackColor = False
        '
        'ButtonDepositar
        '
        Me.ButtonDepositar.BackColor = System.Drawing.Color.Gray
        Me.ButtonDepositar.Location = New System.Drawing.Point(351, 66)
        Me.ButtonDepositar.Name = "ButtonDepositar"
        Me.ButtonDepositar.Size = New System.Drawing.Size(292, 61)
        Me.ButtonDepositar.TabIndex = 2
        Me.ButtonDepositar.Text = "DEPOSITAR"
        Me.ButtonDepositar.UseVisualStyleBackColor = False
        '
        'ButtonCambiodeusuario
        '
        Me.ButtonCambiodeusuario.BackColor = System.Drawing.Color.Gray
        Me.ButtonCambiodeusuario.Location = New System.Drawing.Point(29, 150)
        Me.ButtonCambiodeusuario.Name = "ButtonCambiodeusuario"
        Me.ButtonCambiodeusuario.Size = New System.Drawing.Size(292, 61)
        Me.ButtonCambiodeusuario.TabIndex = 3
        Me.ButtonCambiodeusuario.Text = "Cambio de Usuario"
        Me.ButtonCambiodeusuario.UseVisualStyleBackColor = False
        '
        'ButtonContraseña
        '
        Me.ButtonContraseña.BackColor = System.Drawing.Color.Gray
        Me.ButtonContraseña.Location = New System.Drawing.Point(351, 146)
        Me.ButtonContraseña.Name = "ButtonContraseña"
        Me.ButtonContraseña.Size = New System.Drawing.Size(292, 68)
        Me.ButtonContraseña.TabIndex = 4
        Me.ButtonContraseña.Text = "Cambio de Contraseña"
        Me.ButtonContraseña.UseVisualStyleBackColor = False
        '
        'ButtonSaldo
        '
        Me.ButtonSaldo.BackColor = System.Drawing.Color.Gray
        Me.ButtonSaldo.Location = New System.Drawing.Point(29, 236)
        Me.ButtonSaldo.Name = "ButtonSaldo"
        Me.ButtonSaldo.Size = New System.Drawing.Size(292, 68)
        Me.ButtonSaldo.TabIndex = 5
        Me.ButtonSaldo.Text = "Consultar Saldo"
        Me.ButtonSaldo.UseVisualStyleBackColor = False
        '
        'ButtonMovimientos
        '
        Me.ButtonMovimientos.BackColor = System.Drawing.Color.Gray
        Me.ButtonMovimientos.Location = New System.Drawing.Point(351, 236)
        Me.ButtonMovimientos.Name = "ButtonMovimientos"
        Me.ButtonMovimientos.Size = New System.Drawing.Size(292, 68)
        Me.ButtonMovimientos.TabIndex = 6
        Me.ButtonMovimientos.Text = "Consultar Movimientos"
        Me.ButtonMovimientos.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 425)
        Me.Controls.Add(Me.ButtonMovimientos)
        Me.Controls.Add(Me.ButtonSaldo)
        Me.Controls.Add(Me.ButtonContraseña)
        Me.Controls.Add(Me.ButtonCambiodeusuario)
        Me.Controls.Add(Me.ButtonDepositar)
        Me.Controls.Add(Me.ButtonRetirar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRetirar As Button
    Friend WithEvents ButtonDepositar As Button
    Friend WithEvents ButtonCambiodeusuario As Button
    Friend WithEvents ButtonContraseña As Button
    Friend WithEvents ButtonSaldo As Button
    Friend WithEvents ButtonMovimientos As Button
End Class
