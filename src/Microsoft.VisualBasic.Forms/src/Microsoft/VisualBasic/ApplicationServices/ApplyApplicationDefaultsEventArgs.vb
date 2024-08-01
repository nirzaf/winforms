﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.

Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Analyzers.Diagnostics

Namespace Microsoft.VisualBasic.ApplicationServices

    ''' <summary>
    '''  Provides context for the ApplyApplicationDefaults event.
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Advanced), ComVisible(False)>
    Public Class ApplyApplicationDefaultsEventArgs
        Inherits EventArgs

#Disable Warning WFO5001
#Disable Warning WFO5000
        Friend Sub New(minimumSplashScreenDisplayTime As Integer,
                highDpiMode As HighDpiMode,
                colorMode As SystemColorMode,
                visualStylesMode As VisualStylesMode)

            Me.MinimumSplashScreenDisplayTime = minimumSplashScreenDisplayTime
            Me.HighDpiMode = highDpiMode
            Me.ColorMode = colorMode
            Me.VisualStylesMode = visualStylesMode

        End Sub
#Enable Warning WFO5000
#Enable Warning WFO5001

        ''' <summary>
        '''  Setting this property inside the event handler causes a new default Font for Forms and UserControls to be set.
        ''' </summary>
        ''' <remarks>
        '''  When the ApplyApplicationDefault event is raised, this property contains nothing. A new default Font for the
        '''  application is applied by setting this property with a value different than nothing.
        ''' </remarks>
        Public Property Font As Font

        ''' <summary>
        '''  Setting this Property inside the event handler determines how long an application's Splash dialog is displayed at a minimum.
        ''' </summary>
        Public Property MinimumSplashScreenDisplayTime As Integer =
            WindowsFormsApplicationBase.MINIMUM_SPLASH_EXPOSURE_DEFAULT

        ''' <summary>
        '''  Setting this Property inside the event handler determines the general HighDpiMode for the application.
        ''' </summary>
        ''' <remarks>
        '''  The default value for this property is SystemAware.
        ''' </remarks>
        Public Property HighDpiMode As HighDpiMode

        ''' <summary>
        '''  Setting this property inside the event handler determines the <see cref="Application.ColorMode"/> for the application.
        ''' </summary>
        <Experimental(DiagnosticIDs.ExperimentalDarkMode)>
        Public Property ColorMode As SystemColorMode

        ''' <summary>
        '''  Setting this property inside the event handler determines the <see cref="VisualStylesMode"/> for the application.
        ''' </summary>
        ''' <returns></returns>
        <Experimental(DiagnosticIDs.ExperimentalVisualStyles)>
        Public Property VisualStylesMode As VisualStylesMode

    End Class
#Disable Warning WFO5000
#Disable Warning WFO5001
End Namespace
