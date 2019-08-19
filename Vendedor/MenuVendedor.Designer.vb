<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuVendedor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.LApellidoNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GVendedor = New System.Windows.Forms.GroupBox()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.Lhora = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        '
        'BVentas
        '
        resources.ApplyResources(Me.BVentas, "BVentas")
        Me.BVentas.ForeColor = System.Drawing.Color.Black
        Me.BVentas.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__3_1
        Me.BVentas.Name = "BVentas"
        Me.BVentas.UseVisualStyleBackColor = True
        '
        'BClientes
        '
        resources.ApplyResources(Me.BClientes, "BClientes")
        Me.BClientes.ForeColor = System.Drawing.Color.Black
        Me.BClientes.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.vendedor
        Me.BClientes.Name = "BClientes"
        Me.BClientes.UseVisualStyleBackColor = True
        '
        'LApellidoNombre
        '
        resources.ApplyResources(Me.LApellidoNombre, "LApellidoNombre")
        Me.LApellidoNombre.BackColor = System.Drawing.Color.Transparent
        Me.LApellidoNombre.ForeColor = System.Drawing.Color.White
        Me.LApellidoNombre.Name = "LApellidoNombre"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Name = "Label1"
        '
        'LFecha
        '
        resources.ApplyResources(Me.LFecha, "LFecha")
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Name = "LFecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GVendedor
        '
        Me.GVendedor.BackColor = System.Drawing.Color.Transparent
        Me.GVendedor.Controls.Add(Me.BProductos)
        Me.GVendedor.Controls.Add(Me.BVentas)
        Me.GVendedor.Controls.Add(Me.BClientes)
        resources.ApplyResources(Me.GVendedor, "GVendedor")
        Me.GVendedor.ForeColor = System.Drawing.Color.White
        Me.GVendedor.Name = "GVendedor"
        Me.GVendedor.TabStop = False
        '
        'BProductos
        '
        Me.BProductos.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__1_2
        resources.ApplyResources(Me.BProductos, "BProductos")
        Me.BProductos.Name = "BProductos"
        Me.BProductos.UseVisualStyleBackColor = True
        '
        'Lhora
        '
        resources.ApplyResources(Me.Lhora, "Lhora")
        Me.Lhora.BackColor = System.Drawing.Color.Transparent
        Me.Lhora.ForeColor = System.Drawing.Color.Black
        Me.Lhora.Name = "Lhora"
        '
        'MenuVendedor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ControlBox = False
        Me.Controls.Add(Me.Lhora)
        Me.Controls.Add(Me.GVendedor)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LApellidoNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuVendedor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GVendedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents BVentas As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LApellidoNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Lhora As System.Windows.Forms.Label
    Friend WithEvents BProductos As System.Windows.Forms.Button
End Class
