<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picBoxDisplay = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBlackBlock = New System.Windows.Forms.RadioButton()
        Me.radMosaic = New System.Windows.Forms.RadioButton()
        Me.radFuzzy = New System.Windows.Forms.RadioButton()
        Me.radInverse = New System.Windows.Forms.RadioButton()
        Me.radSimilarColourApproach = New System.Windows.Forms.RadioButton()
        Me.radNonSimilarColourApproach = New System.Windows.Forms.RadioButton()
        Me.radExpLightening = New System.Windows.Forms.RadioButton()
        Me.radLogisticWhiten = New System.Windows.Forms.RadioButton()
        Me.radBoundedLightening = New System.Windows.Forms.RadioButton()
        Me.radLinearLightening = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBarStrength = New System.Windows.Forms.TrackBar()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblRGB = New System.Windows.Forms.Label()
        Me.TrackBarR = New System.Windows.Forms.TrackBar()
        Me.TrackBarG = New System.Windows.Forms.TrackBar()
        Me.TrackBarB = New System.Windows.Forms.TrackBar()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBlackAndWhite = New System.Windows.Forms.RadioButton()
        Me.radColour = New System.Windows.Forms.RadioButton()
        Me.radDistortion = New System.Windows.Forms.RadioButton()
        CType(Me.picBoxDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBarStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBoxDisplay
        '
        Me.picBoxDisplay.Location = New System.Drawing.Point(8, 8)
        Me.picBoxDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picBoxDisplay.Name = "picBoxDisplay"
        Me.picBoxDisplay.Size = New System.Drawing.Size(475, 387)
        Me.picBoxDisplay.TabIndex = 0
        Me.picBoxDisplay.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDistortion)
        Me.GroupBox1.Controls.Add(Me.radBlackBlock)
        Me.GroupBox1.Controls.Add(Me.radMosaic)
        Me.GroupBox1.Controls.Add(Me.radFuzzy)
        Me.GroupBox1.Controls.Add(Me.radInverse)
        Me.GroupBox1.Controls.Add(Me.radSimilarColourApproach)
        Me.GroupBox1.Controls.Add(Me.radNonSimilarColourApproach)
        Me.GroupBox1.Controls.Add(Me.radExpLightening)
        Me.GroupBox1.Controls.Add(Me.radLogisticWhiten)
        Me.GroupBox1.Controls.Add(Me.radBoundedLightening)
        Me.GroupBox1.Controls.Add(Me.radLinearLightening)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 226)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Method"
        '
        'radBlackBlock
        '
        Me.radBlackBlock.AutoSize = True
        Me.radBlackBlock.Location = New System.Drawing.Point(5, 188)
        Me.radBlackBlock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBlackBlock.Name = "radBlackBlock"
        Me.radBlackBlock.Size = New System.Drawing.Size(95, 16)
        Me.radBlackBlock.TabIndex = 10
        Me.radBlackBlock.TabStop = True
        Me.radBlackBlock.Text = "Black Blocks"
        Me.radBlackBlock.UseVisualStyleBackColor = True
        '
        'radMosaic
        '
        Me.radMosaic.AutoSize = True
        Me.radMosaic.Location = New System.Drawing.Point(5, 169)
        Me.radMosaic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radMosaic.Name = "radMosaic"
        Me.radMosaic.Size = New System.Drawing.Size(59, 16)
        Me.radMosaic.TabIndex = 9
        Me.radMosaic.TabStop = True
        Me.radMosaic.Text = "Mosaic"
        Me.radMosaic.UseVisualStyleBackColor = True
        '
        'radFuzzy
        '
        Me.radFuzzy.AutoSize = True
        Me.radFuzzy.Location = New System.Drawing.Point(5, 151)
        Me.radFuzzy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radFuzzy.Name = "radFuzzy"
        Me.radFuzzy.Size = New System.Drawing.Size(53, 16)
        Me.radFuzzy.TabIndex = 8
        Me.radFuzzy.TabStop = True
        Me.radFuzzy.Text = "Fuzzy"
        Me.radFuzzy.UseVisualStyleBackColor = True
        '
        'radInverse
        '
        Me.radInverse.AutoSize = True
        Me.radInverse.Location = New System.Drawing.Point(5, 132)
        Me.radInverse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radInverse.Name = "radInverse"
        Me.radInverse.Size = New System.Drawing.Size(107, 16)
        Me.radInverse.TabIndex = 7
        Me.radInverse.TabStop = True
        Me.radInverse.Text = "Inverse Colour"
        Me.radInverse.UseVisualStyleBackColor = True
        '
        'radSimilarColourApproach
        '
        Me.radSimilarColourApproach.AutoSize = True
        Me.radSimilarColourApproach.Location = New System.Drawing.Point(5, 113)
        Me.radSimilarColourApproach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radSimilarColourApproach.Name = "radSimilarColourApproach"
        Me.radSimilarColourApproach.Size = New System.Drawing.Size(161, 16)
        Me.radSimilarColourApproach.TabIndex = 6
        Me.radSimilarColourApproach.TabStop = True
        Me.radSimilarColourApproach.Text = "Similar Colour Approach"
        Me.radSimilarColourApproach.UseVisualStyleBackColor = True
        '
        'radNonSimilarColourApproach
        '
        Me.radNonSimilarColourApproach.AutoSize = True
        Me.radNonSimilarColourApproach.Location = New System.Drawing.Point(5, 95)
        Me.radNonSimilarColourApproach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radNonSimilarColourApproach.Name = "radNonSimilarColourApproach"
        Me.radNonSimilarColourApproach.Size = New System.Drawing.Size(185, 16)
        Me.radNonSimilarColourApproach.TabIndex = 5
        Me.radNonSimilarColourApproach.TabStop = True
        Me.radNonSimilarColourApproach.Text = "Non-Similar Colour Approach"
        Me.radNonSimilarColourApproach.UseVisualStyleBackColor = True
        '
        'radExpLightening
        '
        Me.radExpLightening.AutoSize = True
        Me.radExpLightening.Location = New System.Drawing.Point(5, 37)
        Me.radExpLightening.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radExpLightening.Name = "radExpLightening"
        Me.radExpLightening.Size = New System.Drawing.Size(155, 16)
        Me.radExpLightening.TabIndex = 4
        Me.radExpLightening.TabStop = True
        Me.radExpLightening.Text = "Exponential Lightening"
        Me.radExpLightening.UseVisualStyleBackColor = True
        '
        'radLogisticWhiten
        '
        Me.radLogisticWhiten.AutoSize = True
        Me.radLogisticWhiten.Location = New System.Drawing.Point(5, 76)
        Me.radLogisticWhiten.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radLogisticWhiten.Name = "radLogisticWhiten"
        Me.radLogisticWhiten.Size = New System.Drawing.Size(137, 16)
        Me.radLogisticWhiten.TabIndex = 3
        Me.radLogisticWhiten.TabStop = True
        Me.radLogisticWhiten.Text = "Logistic Lightening"
        Me.radLogisticWhiten.UseVisualStyleBackColor = True
        '
        'radBoundedLightening
        '
        Me.radBoundedLightening.AutoSize = True
        Me.radBoundedLightening.Location = New System.Drawing.Point(5, 57)
        Me.radBoundedLightening.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBoundedLightening.Name = "radBoundedLightening"
        Me.radBoundedLightening.Size = New System.Drawing.Size(131, 16)
        Me.radBoundedLightening.TabIndex = 1
        Me.radBoundedLightening.TabStop = True
        Me.radBoundedLightening.Text = "Bounded Lightening"
        Me.radBoundedLightening.UseVisualStyleBackColor = True
        '
        'radLinearLightening
        '
        Me.radLinearLightening.AutoSize = True
        Me.radLinearLightening.Location = New System.Drawing.Point(5, 19)
        Me.radLinearLightening.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radLinearLightening.Name = "radLinearLightening"
        Me.radLinearLightening.Size = New System.Drawing.Size(125, 16)
        Me.radLinearLightening.TabIndex = 0
        Me.radLinearLightening.TabStop = True
        Me.radLinearLightening.Text = "Linear Lightening"
        Me.radLinearLightening.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(486, 354)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Strength"
        '
        'TrackBarStrength
        '
        Me.TrackBarStrength.Location = New System.Drawing.Point(543, 349)
        Me.TrackBarStrength.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrackBarStrength.Maximum = 20
        Me.TrackBarStrength.Minimum = 1
        Me.TrackBarStrength.Name = "TrackBarStrength"
        Me.TrackBarStrength.Size = New System.Drawing.Size(238, 45)
        Me.TrackBarStrength.TabIndex = 3
        Me.TrackBarStrength.Value = 1
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(489, 391)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(105, 50)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'lblRGB
        '
        Me.lblRGB.AutoSize = True
        Me.lblRGB.Location = New System.Drawing.Point(488, 239)
        Me.lblRGB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRGB.Name = "lblRGB"
        Me.lblRGB.Size = New System.Drawing.Size(23, 12)
        Me.lblRGB.TabIndex = 5
        Me.lblRGB.Text = "RGB"
        '
        'TrackBarR
        '
        Me.TrackBarR.Location = New System.Drawing.Point(515, 239)
        Me.TrackBarR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrackBarR.Maximum = 255
        Me.TrackBarR.Name = "TrackBarR"
        Me.TrackBarR.Size = New System.Drawing.Size(238, 45)
        Me.TrackBarR.TabIndex = 6
        '
        'TrackBarG
        '
        Me.TrackBarG.Location = New System.Drawing.Point(515, 269)
        Me.TrackBarG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrackBarG.Maximum = 255
        Me.TrackBarG.Name = "TrackBarG"
        Me.TrackBarG.Size = New System.Drawing.Size(238, 45)
        Me.TrackBarG.TabIndex = 7
        '
        'TrackBarB
        '
        Me.TrackBarB.Location = New System.Drawing.Point(515, 302)
        Me.TrackBarB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrackBarB.Maximum = 255
        Me.TrackBarB.Name = "TrackBarB"
        Me.TrackBarB.Size = New System.Drawing.Size(238, 45)
        Me.TrackBarB.TabIndex = 8
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(597, 391)
        Me.btnRandom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(105, 50)
        Me.btnRandom.TabIndex = 9
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radBlackAndWhite)
        Me.GroupBox2.Controls.Add(Me.radColour)
        Me.GroupBox2.Location = New System.Drawing.Point(690, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(172, 201)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Random Method"
        '
        'radBlackAndWhite
        '
        Me.radBlackAndWhite.AutoSize = True
        Me.radBlackAndWhite.Location = New System.Drawing.Point(4, 37)
        Me.radBlackAndWhite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBlackAndWhite.Name = "radBlackAndWhite"
        Me.radBlackAndWhite.Size = New System.Drawing.Size(95, 16)
        Me.radBlackAndWhite.TabIndex = 11
        Me.radBlackAndWhite.TabStop = True
        Me.radBlackAndWhite.Text = "Black & White"
        Me.radBlackAndWhite.UseVisualStyleBackColor = True
        '
        'radColour
        '
        Me.radColour.AutoSize = True
        Me.radColour.Location = New System.Drawing.Point(4, 18)
        Me.radColour.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radColour.Name = "radColour"
        Me.radColour.Size = New System.Drawing.Size(59, 16)
        Me.radColour.TabIndex = 10
        Me.radColour.TabStop = True
        Me.radColour.Text = "Colour"
        Me.radColour.UseVisualStyleBackColor = True
        '
        'radDistortion
        '
        Me.radDistortion.AutoSize = True
        Me.radDistortion.Location = New System.Drawing.Point(5, 208)
        Me.radDistortion.Margin = New System.Windows.Forms.Padding(2)
        Me.radDistortion.Name = "radDistortion"
        Me.radDistortion.Size = New System.Drawing.Size(125, 16)
        Me.radDistortion.TabIndex = 12
        Me.radDistortion.TabStop = True
        Me.radDistortion.Text = "Random Distortion"
        Me.radDistortion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.TrackBarB)
        Me.Controls.Add(Me.TrackBarG)
        Me.Controls.Add(Me.TrackBarR)
        Me.Controls.Add(Me.lblRGB)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.TrackBarStrength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picBoxDisplay)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBoxDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBarStrength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxDisplay As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radLogisticWhiten As RadioButton
    Friend WithEvents radBoundedLightening As RadioButton
    Friend WithEvents radLinearLightening As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBarStrength As TrackBar
    Friend WithEvents btnFilter As Button
    Friend WithEvents radExpLightening As RadioButton
    Friend WithEvents radNonSimilarColourApproach As RadioButton
    Friend WithEvents lblRGB As Label
    Friend WithEvents TrackBarR As TrackBar
    Friend WithEvents TrackBarG As TrackBar
    Friend WithEvents TrackBarB As TrackBar
    Friend WithEvents radSimilarColourApproach As RadioButton
    Friend WithEvents radInverse As RadioButton
    Friend WithEvents radFuzzy As RadioButton
    Friend WithEvents radMosaic As RadioButton
    Friend WithEvents btnRandom As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radBlackAndWhite As RadioButton
    Friend WithEvents radColour As RadioButton
    Friend WithEvents radBlackBlock As RadioButton
    Friend WithEvents radDistortion As RadioButton
End Class
