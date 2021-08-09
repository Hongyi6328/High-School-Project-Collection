Imports System.Xml
Imports System.IO
Module Module1
    Dim _case_global As String
    Dim oxygen(861)
    Dim oxygen_Lengthened(861)
    Dim salinity(37)
    Dim salinity_Modded(18)
    Dim salinity_key = {0, 10, 20, 30, 50, 75, 100, 125, 150, 200, 250,
        300, 400, 500, 600, 700, 800, 900, 1000}
    Dim GeoDepth(,), GeoSalinity(30, 30), GeoTemp(30, 30)
    Dim CurrentYear = 2020
    Dim Temp_Score_M, Sali_Score_M, Depth_Score_M, Oxy_Score_M As Double
    Dim Temp_Score_H, Sali_Score_H, Depth_Score_H, Oxy_Score_H As Double
    Sub Main()
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode1, xmlnode2 As XmlNodeList
        Dim str As String
        Dim fs As New FileStream("North Hemisphere Ocean Temperature.xml", FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode2 = xmldoc.GetElementsByTagName("data")
        Dim coeOutput(xmlnode2.Count - 1)
        For i = 0 To xmlnode2.Count - 1
            coeOutput(i) = xmlnode2(i).ChildNodes.Item(1).InnerText.Trim()
        Next
        Dim fileReader = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\Scottish Fishery_console\Scottish Fishery_console\bin\DeBug\Oxygen vs Salinity & Temp ( Temp_ 0_20 ).txt")
        str = fileReader.ToString
        Dim acc = 0
        Dim TempStr = ""
        For i = 0 To str.Length - 1
            If str(i) = "." Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    Oxygen(acc) = TempStr
                    acc += 1
                    TempStr = ""
                End If
            End If
        Next
        fileReader = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\Scottish Fishery_console\Scottish Fishery_console\bin\DeBug\Oxygen vs Salinity & Temp ( Temp_ 0_100 ).txt")
        str = fileReader.ToString
        acc = 0
        TempStr = ""
        For i = 0 To str.Length - 1
            If str(i) = "." Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    Oxygen_Lengthened(acc) = TempStr
                    acc += 1
                    TempStr = ""
                End If
            End If
        Next
        fileReader = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\Scottish Fishery_console\Scottish Fishery_console\bin\DeBug\SalinityVsDepth.txt")
        str = fileReader.ToString
        acc = 0
        TempStr = ""
        For i = 0 To str.Length - 1
            If str(i) = "." Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    salinity(acc) = TempStr
                    acc += 1
                    TempStr = ""
                End If
            End If
        Next
        acc = 0
        For i = 0 To 37
            If Math.IEEERemainder(i, 2) = 0 Then
                salinity_Modded(acc) = (Salinity(i) + Salinity(i + 1) / 2)
                acc += 1
            End If
        Next
        ExtractTemp()
        ExtractSali()
        Dim _case = {"Best", "Worst"}
        For j = 0 To 1
            CurrentYear = 2020
            _case_global = _case(j)
            Console.WriteLine("###################" & _case(j) & "###################")
            Dim locMackerel = {59, -5}
            Dim HisAvgTemp = 9.083333
            Console.WriteLine("*************Mackerel************")
            For i = 1 To 51
                Console.WriteLine("--------" & CurrentYear & "--------")
                Console.WriteLine(Math.Round(EstimateTempAnomaly(CurrentYear, _case(j)) +
                                             HisAvgTemp, 4) & " °C")
                Dim newLoc(1)
                newLoc(0) = YearlyMoving("Mackerel", locMackerel(0), locMackerel(1))(0)
                newLoc(1) = YearlyMoving("Mackerel", locMackerel(0), locMackerel(1))(1)
                locMackerel(0) = newLoc(0)
                locMackerel(1) = newLoc(1)
                Console.WriteLine("Location: " & locMackerel(0) & ", " & locMackerel(1))
                Console.WriteLine("Score: " & Math.Round(Score("Mackerel", locMackerel(0), locMackerel(1)), 2))
                Console.WriteLine(
                    "Temp: " & Math.Round(GeoTemp(locMackerel(0) - 50, locMackerel(1) + 20) /
                    9.0833 * (EstimateTempAnomaly(CurrentYear, _case_global) + 9.0833), 2).ToString)
                Console.WriteLine("Living Temp: " & Math.Round(Temp_Score_M, 2))
                Console.WriteLine("Sali: " & Math.Round(Sali_Score_M, 2))
                Console.WriteLine("Depth: " & Math.Round(Depth_Score_M), 2)
                Console.WriteLine("Oxy: " & Math.Round(Oxy_Score_M, 2))
                CurrentYear += 1
            Next
            Dim locHerring = {52, -7}
            Console.WriteLine("*************Herring************")
            CurrentYear = 2020
            For i = 1 To 51
                Console.WriteLine("--------" & CurrentYear & "--------")
                Console.WriteLine(Math.Round(EstimateTempAnomaly(CurrentYear, _case(j)) + HisAvgTemp, 4) & " °C")
                Dim newLoc(1)
                newLoc(0) = Val(YearlyMoving("Herring", locHerring(0), locHerring(1))(0))
                newLoc(1) = Val(YearlyMoving("Herring", locHerring(0), locHerring(1))(1))
                locHerring(0) = newLoc(0)
                locHerring(1) = newLoc(1)
                Console.WriteLine("Location: " & locHerring(0) & ", " & locHerring(1))
                Console.WriteLine("Score: " & Math.Round(Score("Herring", locHerring(0),
                locHerring(1)), 2))
                Console.WriteLine(
                "Surf Temp: " & Math.Round(GeoTemp(locHerring(0) - 50, locHerring(1) + 20) /
                9.0833 * (EstimateTempAnomaly(CurrentYear, _case_global) + 9.0833), 2).ToString)
                Console.WriteLine("Living Temp: " & Math.Round(Temp_Score_H, 2))
                Console.WriteLine("Sali: " & Math.Round(Sali_Score_H, 2))
                Console.WriteLine("Depth: " & Math.Round(Depth_Score_H, 2))
                Console.WriteLine("Oxy: " & Math.Round(Oxy_Score_H, 2))
                CurrentYear += 1
            Next
        Next
        Console.Read()
    End Sub
    Sub ExtractTemp()
        Dim fs = My.Computer.FileSystem.ReadAllText _
            ("C:\Users\qo\source\repos\csv_combiner\csv_combiner\bin\DeBug\Temp_Combined.txt")
        Dim str As String = fs.ToString
        Dim TempStr = ""
        Dim acc = 0
        Dim temp_str(99999)
        For i = 0 To str.Length - 1
            If str(i) = "." Or str(i) = "-" Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    temp_str(acc) = Val(TempStr)
                    acc = acc + 1
                    TempStr = ""
                End If
            End If
        Next
        For i = 0 To 2882
            If Math.IEEERemainder(i, 3) = 0 Then
                GeoTemp(temp_str(i) - 50, temp_str(1 + i) + 20) = Val(temp_str(i + 2))
            End If
        Next
    End Sub
    Sub ExtractSali()
        Dim fs = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\csv_combiner\csv_combiner\bin\DeBug\Sali_Combined.txt")
        Dim str As String = fs.ToString
        Dim TempStr = ""
        Dim acc = 0
        Dim sali_str(99999)
        For i = 0 To str.Length - 1
            If str(i) = "." Or str(i) = "-" Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    sali_str(acc) = Val(TempStr)
                    acc = acc + 1
                    TempStr = ""
                End If
            End If
        Next
        For i = 0 To 2882
            If Math.IEEERemainder(i, 3) = 0 Then
                GeoSalinity(sali_str(i) - 50, sali_str(1 + i) + 20) = Val(sali_str(i + 2))
            End If
        Next
    End Sub
    Function TempVsDepth(Depth As Integer, SurfaceTemp As Single)
        Dim temp
        If Depth <= 200 Then
            Return SurfaceTemp
        ElseIf 200 < Depth <= 1000 Then
            temp = SurfaceTemp * ((Math.Exp(-(Depth - 200) / 800)) ^ 2 +
                Math.Exp(-(Depth - 200) / 800)) / 2
            Return temp
        ElseIf Depth > 1000 Then
            temp = 6
            Return temp
        Else
            Return "NaN"
        End If
    End Function
    Function HerringLocationVsMonth(CentreN, CentreE, month)
        Dim LocationN, LocationE
        LocationN = 8.22605 * Math.Sin(Math.PI / 6 * (-month - Math.PI / 2)) + CentreN
        LocationE = 9.14865 * Math.Cos(Math.PI / 6 * (-month)) + CentreE
        If 0 <= month <= 12 Then
            Return {LocationN, LocationE}
        Else
            Return "NaN"
        End If
    End Function
    Function MackerelLocationVsMonth(CentreN, CentreE, month)
        Dim LocationN, LocationE
        LocationN = 5 * Math.Sin(Math.PI / 6 * (-month() - Math.PI / 2)) + CentreN
        LocationE = 7.5 * Math.Cos(Math.PI / 6 * (-month() - Math.PI / 2)) + CentreE
        If 0 <= month <= 12 Then
            Return {LocationN, LocationE}
        Else
            Return "NaN"
        End If
    End Function

    Function EstimateTempAnomaly(year As Integer, _case As String)
        Dim x = year - 1920
        If _case = "Best" Then
            Return -0.279 + x / 93.932 + Math.Sin((x / 11.44) ^ 0.89) / 3.7
        ElseIf _case = "Worst" Then
            Return -1.317 + (x + 75.5) / 81.03 + Math.Sin(((x + 75.5) / 6.64) ^ 0.78) / 3.19
        End If
    End Function

    Function OxygenVsTempNSalinity(temp, salinity)
        Dim TempRounded, SaliRounded
        If temp > 100 Or salinity > 200 Or temp < 0 Or salinity < 0 Then
            Return "NaN"
        ElseIf temp <= 20 And salinity <= 40 Then
            TempRounded = Math.Floor(temp)
            SaliRounded = Math.Floor(salinity)
            Dim i = SaliRounded * 21 + TempRounded
            Dim average = ((Oxygen(i + 1) - Oxygen(i)) * (temp - TempRounded) + Oxygen(i) _
                + (Oxygen(i + 22) - Oxygen(i + 21)) * (temp - TempRounded) + Oxygen(i + 21)) _
                * (salinity - SaliRounded)
            Return average
        Else
            TempRounded = Math.Floor(temp / 5)
            SaliRounded = Math.Floor(salinity / 5)
            Dim i = SaliRounded * 21 + TempRounded
            Dim average = ((Oxygen(i + 1) - Oxygen(i)) * (temp - TempRounded) / 5 + Oxygen(i) _
                + (Oxygen(i + 22) - Oxygen(i + 21)) * (temp - TempRounded) / 5 + Oxygen(i + 21)) _
                * (salinity - SaliRounded) / 5
            Return average
        End If
    End Function

    Function SalinityVsPressureNSurfaceTemp(pressure, SurfaceTemp) 'pressure ::= sigma_t
        Dim At = SurfaceTemp * (4.7867 - 0.098185 * SurfaceTemp + 0.0010843 * SurfaceTemp ^ 2) / 1000
        Dim Bt = SurfaceTemp * (18.03 - 0.8164 * SurfaceTemp + 0.01667 * SurfaceTemp ^ 2) / 1000000
        Dim Sumt = (SurfaceTemp - 3.98) ^ 2 / 503.57 * (SurfaceTemp + 283) / (SurfaceTemp + 67.26)
        Dim a2 = Bt, b2 = -At + 1, c2 = -331 * At / 2500 + Sumt - 331 ^ 2 * Bt / 2500 ^ 2 +
            331 / 2500 - pressure
        Dim sigma_0_root1, sigma_0_root2
        If b2 ^ 2 - 4 * a2 * c2 < 0 Then
            Console.WriteLine("No real roots : SalinityVsPressureNSurfaceTemp, sigma_0")
            Return "NaN"
            Exit Function
        ElseIf b2 ^ 2 - 4 * a2 * c2 = 0 Then
            sigma_0_root1 = (-b2) / 2 / a2
        Else
            sigma_0_root1 = (-b2 + (b2 ^ 2 - 4 * a2 * c2) ^ (1 / 2)) / 2 / a2
            sigma_0_root2 = (-b2 - (b2 ^ 2 - 4 * a2 * c2) ^ (1 / 2)) / 2 / a2
            Console.WriteLine("sigma_0_root_1 = " & sigma_0_root1)
            Console.WriteLine("sigma_0_root_2 = " & sigma_0_root2)
        End If
        If (sigma_0_root1 > 0 And sigma_0_root2 > 0) Then
            Console.Write("Two positive roots")
            Return "NaN"
            Exit Function
        ElseIf (sigma_0_root1 < 0 And sigma_0_root2 < 0) Then
            Console.WriteLine("Two negative roots")
            Return "NaN"
            Exit Function
        ElseIf sigma_0_root2 > 0 Then
            sigma_0_root1 = sigma_0_root2
        End If
        Dim a3 = 0.0000398, b3 = -0.00157, c3 = 1.4708, d3 = -0.069 - sigma_0_root1
        Dim delta = (b3 * c3 / 6 / a3 ^ 2 - b3 ^ 3 / 27 / a3 ^ 3 - d3 / 2 / a3) ^ 2 +
            (c3 / 3 / a3 - b3 ^ 2 / 9 / a3 ^ 2) ^ 3
        Dim cl
        If Not delta > 0 Then
            Console.Write("Not only one real root : SalinityVsPressure, Cl")
            Return "NaN"
            Exit Function
        Else
            cl = -b3 / 3 / a3 +
                (b3 * c3 / 6 / a3 ^ 2 - b3 ^ 3 / 27 / a3 ^ 3 - d3 / 2 / a3 + delta ^ 0.5) ^ (1 / 3) +
                （b3 * c3 / 6 / a3 ^ 2 - b3 ^ 3 / 27 / a3 ^ 3 - d3 / 2 / a3 - delta ^ 0.5) ^ (1 / 3)
            Dim salinity = 0.03 + 1.805 * cl
            Return salinity
        End If
    End Function

    Function SalinityVsDepth(depth)
        Dim dir
        If depth = 0 Then
            Return 40
        ElseIf 0 < depth <= 30 Then
            dir = Math.Ceiling(depth / 10) - 1
        ElseIf 30 < depth <= 50 Then
            dir = 4
        ElseIf 50 < depth <= 150 Then
            dir = Math.Ceiling(depth / 25) + 2
        ElseIf 150 < depth <= 300 Then
            dir = Math.Ceiling(depth / 50) + 5
        ElseIf 300 < depth <= 1000 Then
            dir = Math.Ceiling(depth / 100) + 8
        Else
            Return "NaN"
            Exit Function
        End If
        Return (depth - salinity_key(dir)) / (salinity_key(dir + 1) - salinity_key(dir)) *
            (salinity_Modded(dir) _
             + salinity_Modded(dir + 1)) / 2 + salinity_Modded(dir)
    End Function

    Function YearlyMoving(fish, EggLocN, EggLocE)
        Dim key(1)
        Dim highest = 0
        For j = -1 To 1
            For i = -1 To 1
                Dim temp = Score(fish, EggLocN + i, EggLocE + j)
                If temp > highest Then
                    highest = temp
                    key = {i, j}
                End If
            Next
        Next
        If highest = Score(fish, EggLocN, EggLocE) Then
            key(0) = 0
            key(1) = 0
        End If
        Return {EggLocN + key(0), EggLocE + key(1)}
    End Function

    Function Score(fish, N, E)
        Dim locTemp, locSali, locDepth 'Sigma_0
        Dim livingDepth, livingtemp, livingsali, livingOxy
        Dim tempScore, saliScore, oxyScore, depthScore
        Try
            If fish = "Herring" Then
                locTemp = 1.87533 + GeoTemp(N - 50, E + 20) / 9.0833 *
                    (EstimateTempAnomaly(CurrentYear, _case_global) + 9.0833)
            Else
                locTemp = -1.79133 + GeoTemp(N - 50, E + 20) / 9.0833 *
                    (EstimateTempAnomaly(CurrentYear, _case_global) + 9.0833)
            End If
            locSali = SaliVsYear (CurrentYear ,GeoSalinity(N - 50, E + 20))
            locDepth = 1000
        Catch ex As Exception
            Return 0
            Exit Function
        End Try
        If fish = "Mackerel" Then
            'Temp R anking & Depth Ranking
            If 8 <= locTemp And locTemp <= 18 Then
                depthScore = 100
                livingDepth = 100
                livingtemp = locTemp
            ElseIf locTemp > 18 Then
                Dim mostFitTemp = 0, tempDiff = 1000, mostFitDepth = 1000
                For i = 10 To 50
                    If i * 20 > locDepth Then
                        Exit For
                    End If
                    livingtemp = TempVsDepth(i * 20, locTemp)
                    If Math.Abs(livingtemp - 13) < tempDiff Then
                        tempDiff = Math.Abs(livingtemp - 13)
                        mostFitTemp = livingtemp
                        mostFitDepth = i * 20
                    End If
                Next
                locTemp = mostFitTemp
                livingDepth = mostFitDepth
                depthScore = 100 - (locDepth - 100) ^ 2 / 9000
            Else depthScore = 100 - (locDepth - 100) ^ 2 / 18000
            End If
            tempScore = 100 - (locTemp - 8.9) ^ 2 * 1.2
            livingsali = SaliVsYear(CurrentYear, GeoSalinity(N - 50, E + 20))
            saliScore = 100 - (livingsali - 30) ^ 2 / 16.81
            livingOxy = OxygenVsTempNSalinity(locTemp, livingsali)
            oxyScore = livingOxy / 10
            Oxy_Score_M = livingOxy
            Sali_Score_M = livingsali
            Depth_Score_M = livingDepth
            Temp_Score_M = livingtemp
            Return tempScore * 0.4 + depthScore * 0.3 + saliScore * 0.15 + oxyScore * 0.15
        ElseIf fish = "Herring" Then
            If 5 <= locTemp And locTemp <= 15 Then
                depthScore = 100
                livingDepth = 100
                livingtemp = locTemp
            ElseIf locTemp > 15 Then
                Dim mostFitTemp = 0, tempDiff = 1000, mostFitDepth = 1000
                For i = 10 To 50
                    If i * 20 > locDepth Then
                        Exit For
                    End If
                    livingtemp = TempVsDepth(i * 20, locTemp)
                    If Math.Abs(livingtemp - 12.5) < tempDiff Then
                        tempDiff = Math.Abs(livingtemp - 12.5)
                        mostFitTemp = livingtemp
                        mostFitDepth = i * 20
                    End If
                Next
                locTemp = mostFitTemp
                livingDepth = mostFitDepth
                depthScore = 100 - (locDepth - 100) ^ 2 / 700
            Else depthScore = 100 - (locDepth - 100) ^ 2 / 1800
            End If
            tempScore = 100 - (locTemp - 16) ^ 2 / 23
            livingsali = SaliVsYear(CurrentYear, GeoSalinity(N - 50, E + 20))
            saliScore = 100 - (livingsali - 11) ^ 2
            livingOxy = OxygenVsTempNSalinity(locTemp, livingsali)
            oxyScore = livingOxy / 10
            Oxy_Score_H = livingOxy
            Sali_Score_H = livingsali
            Depth_Score_H = livingDepth
            Temp_Score_H = livingtemp
            Return tempScore * 0.9 + depthScore * 0.1 + saliScore * 0.15 + oxyScore * 0.15
        End If
    End Function

    Function SaliVsYear(year, iniSali)
        year = CurrentYear
        Return (32.5 + 1.4 * Math.Sin((CurrentYear - 1980) / 10)) * (iniSali / 33.0772) ^ (1 / 1.5)
    End Function

End Module

Module Module2

    Dim temperature_str(35999) As Double
    Dim temperature_total(30, 30) As Double
    Dim temperature_amount(30, 30) As Double
    Dim temperature_geo(30, 30) As Double
    Dim sali_str(36000) As Double
    Dim sali_total(30, 30) As Double
    Dim sali_amount(30, 30) As Double
    Dim sali_geo(30, 30) As Double

    Sub Sali()
        Dim fs = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\csv_combiner\csv_combiner\bin\DeBug\Sali.txt")
        Dim str As String = fs.ToString
        Dim TempStr = ""
        Dim acc = 0
        For i = 0 To str.Length - 1
            If str(i) = "." Or str(i) = "-" Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    sali_str(acc) = Val(TempStr)
                    acc = acc + 1
                    TempStr = ""
                End If
            End If
        Next
        For i = 0 To 29732
            If Math.IEEERemainder(i, 3) = 0 Then
                sali_total(sali_str(i) - 50, sali_str(1 + i) + 20) += Val(sali_str(i + 2))
                sali_amount(sali_str(i) - 50, sali_str(1 + i) + 20) += 1
            End If
        Next
        Dim a = 0
        For i = 0 To 30
            For j = 0 To 30
                If Not sali_amount(i, j) = 0 Then
                    sali_geo(i, j) = sali_total(i, j) / sali_amount(i, j)
                Else
                    sali_geo(i, j) = 0
                    a += 1
                End If
                Console.WriteLine((i + 50).ToString & " " & (j - 20).ToString & " " &
                                  Math.Round(sali_geo(i, j), 4))
            Next
        Next
        Console.WriteLine(a)
    End Sub

    Sub Main()
        Sali()
        Temp()
        Console.Read()
    End Sub

    Sub Temp()

        Dim fs = My.Computer.FileSystem.ReadAllText(
            "C:\Users\qo\source\repos\csv_combiner\csv_combiner\bin\DeBug\Temperature.txt")
        Dim str As String = fs.ToString
        Dim TempStr = ""
        Dim acc = 0
        For i = 0 To str.Length - 1
            If str(i) = "." Or str(i) = "-" Or IsNumeric(str(i)) Then
                TempStr &= str(i)
            Else
                If Not TempStr = "" Then
                    temperature_str(acc) = Val(TempStr)
                    acc = acc + 1
                    TempStr = ""
                End If
            End If
        Next
        For i = 0 To 31415
            If Math.IEEERemainder(i, 3) = 0 Then
                temperature_total(temperature_str(i) - 50,
                                  temperature_str(1 + i) + 20) += Val(temperature_str(i + 2))
                temperature_amount(temperature_str(i) - 50, temperature_str(1 + i) + 20) += 1
            End If
        Next
        Dim a = 0
        For i = 0 To 30
            For j = 0 To 30
                If Not temperature_amount(i, j) = 0 Then
                    temperature_geo(i, j) = temperature_total(i, j) / temperature_amount(i, j)
                Else
                    temperature_geo(i, j) = 0
                    a += 1
                End If
                Console.WriteLine((i + 50).ToString & " " & (j - 20).ToString & " " &
                                  Math.Round(temperature_geo(i, j), 4))
            Next
        Next
        Console.WriteLine(a)
    End Sub

End Module
