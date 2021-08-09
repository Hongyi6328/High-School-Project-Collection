Imports System.IO
Imports System.Drawing
Imports System.Random
Imports System.Drawing.Printing
Imports System.Runtime
Class Form1

    Dim rating(133), iniPrice(133), finPrice(133), popularity(133) As Single
    Dim order(133), quantity(133) As Integer
    Dim category(133), brand(133), type(133), nameOfProduct(133), department(133) As String
    Dim intensity(95, 95) As Single, placement(95, 95) As Boolean
    Dim customers(999, 6)
    'Number, (CurrentLoc(1), Target(1), carrying what, damaged or not, start/checkout/return)
    'not started:=0 started:=1 checking out:=2 returning:=3, returned:=4
    Dim departments = {{"Appliances", 0, 0}, {"Audio", 0, 0}, {"Cameras", 0, 0},
{"Cell Phones", 0, 0}, {"Computers&Tablets", 0, 0}, {"TV&Home Theater", 0, 0},
{"Video Gaming", 0, 0}} 'name, amount, sum of pop
    Dim categories = {{"Laundry Appliances", 0, 0}, {"Major Kitchen Appliances", 0, 0},
{"Vacuum Cleaners & Floor Care", 0, 0}, {"Headphones", 0, 0}, {"DSLR Cameras", 0, 0},
{"Mirrorless Cameras", 0, 0}, {"Cell Phones and Accessories", 0, 0},
{"Desktops and All-In-Ones", 0, 0}, {"Laptops", 0, 0}, {"Monitors", 0, 0}, {"Printers", 0, 0},
{"Tablets", 0, 0}, {"TVS 30" & Chr(34) & " to 45" & Chr(34), 0, 0},
{"TVS 50" & Chr(34) & " - 55" & Chr(34), 0, 0}, {"TVS 65" & Chr(34), 0, 0},
{"TVS 70" & Chr(34) & " - 75" & Chr(34), 0, 0}, {"TVS 85" & Chr(34), 0, 0}, {"Video", 0, 0},
{"Console Game Systems", 0, 0}, {"PC Gaming", 0, 0}}
    Dim types = {{"Dryer", 0, 0}, {"Washer", 0, 0}, {"Dishwasher", 0, 0},
{"Microwave", 0, 0}, {"Range/Stove/Oven", 0, 0}, {"Refrigerator", 0, 0},
{"Robot Vacuum", 0, 0}, {"Stick Vacuum", 0, 0}, {"Upright Vacuum", 0, 0},
{"Wireless Earphones", 0, 0}, {"Body Only", 0, 0}, {"Camera Package", 0, 0},
{"Headsets", 0, 0}, {"All-In-One", 0, 0},
{"Desktop", 0, 0}, {"2-in-1 Chromebook", 0, 0}, {"2-in-1 Laptop", 0, 0},
{"Chromebook", 0, 0}, {"PC Laptop", 0, 0}, {"LED", 0, 0},
{"All-In-One", 0, 0}, {"Tablet", 0, 0}, {"1080p LED Smart", 0, 0},
{"720p LED HDTV", 0, 0}, {"720p LED Smart", 0, 0}, {"4K OLED", 0, 0}, {"4K QLED", 0, 0},
{"4K LED", 0, 0}, {"Blu-Ray Players", 0, 0}, {"Consoles", 0, 0},
{"Gaming Desktop", 0, 0}, {"Gaming Laptop", 0, 0}}
    Dim brands = {{"A", 0, 0}, {"AA", 0, 0}, {"B", 0, 0}, {"BB", 0, 0},
{"C", 0, 0}, {"CC", 0, 0}, {"D", 0, 0}, {"DD", 0, 0},
{"E", 0, 0}, {"EE", 0, 0}, {"F", 0, 0}, {"FF", 0, 0},
{"G", 0, 0}, {"GG", 0, 0}, {"H", 0, 0}, {"HH", 0, 0}, {"I", 0, 0},
{"II", 0, 0}, {"J", 0, 0}, {"K", 0, 0}, {"L", 0, 0}, {"M", 0, 0},
{"N", 0, 0}, {"O", 0, 0}, {"P", 0, 0}, {"Q", 0, 0}, {"R", 0, 0},
{"S", 0, 0}, {"T", 0, 0}, {"V", 0, 0}, {"W", 0, 0}, {"X", 0, 0},
{"Y", 0, 0}, {"Z", 0, 0}}
    Dim sum_pop As Double = 0
    Dim ProductLoc(133, 1), damageList(133)
    Dim validProductLoc(1)
    Dim validProduct(267)
    Dim rnd As New Random
    Dim figure = 1 ' 1 or 2
    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Dim iniQuantity = quantity.Clone
        For i = 0 To customers.Length / 7 - 1
            customers(i, 4) = -1
            customers(i, 5) = 0
            customers(i, 6) = 0
        Next
        Dim StartedCus = 0
        Do
            If StartedCus < customers.Length / 7 - 1 Then
                Dim acc = 0
                For i = 0 To customers.Length / 7 - 1
                    If customers(i, 6) = 0 Then
                        Dim iniLoc = 69 + Math.Round(rnd.NextDouble * 9)
                        customers(i, 0) = iniLoc
                        customers(i, 1) = 95
                        intensity(64, 95) += 1
                        customers(i, 6) = 1
                        Dim ANewTarget = NewTarget(i)
                        customers(i, 2) = ANewTarget(0)
                        customers(i, 3) = ANewTarget(1)
                        acc += 1
                        StartedCus += 1
                        If acc = 10 Then
                            Exit For
                        End If
                    End If
                Next
            End If
            For i = 0 To customers.Length / 7 - 1
                If customers(i, 6) < 4 And customers(i, 6) > 0 Then
                    Dim newLoc = walk(i)
                    intensity(customers(i, 0), customers(i, 1)) -= 1
                    customers(i, 0) = newLoc(0)
                    customers(i, 1) = newLoc(1)
                    intensity(customers(i, 0), customers(i, 1)) += 1
                    Dim d = distance(customers(i, 0), customers(i, 1), customers(i, 2), customers(i, 3))
                    If d <= 1 Then
                        customers(i, 6) += 1
                        If customers(i, 6) < 4 Then
                            Dim ANewTarget = NewTarget(i)
                            customers(i, 2) = ANewTarget(0)
                            customers(i, 3) = ANewTarget(1)
                        End If
                    End If
                End If
            Next
            RefreshImg()
            Threading.Thread.Sleep(3000)
            If cleared() Then
                Exit Do
            End If
        Loop
        For i = 0 To 133
            dgvResult.Rows(i).Cells(3).Value = quantity(i)
            dgvResult.Rows(i).Cells(4).Value = damageList(i)
            dgvResult.Rows(i).Cells(5).Value = (iniQuantity(i) - quantity(i) - damageList(i)) * finPrice(i)
            damageList(i) = 0
        Next
        For i = 0 To customers.Length / 7 - 1
            customers(i, 0) = 64
            customers(i, 1) = 95
            customers(i, 4) = -1
            customers(i, 5) = 0
            customers(i, 6) = 0
        Next
        For i = 0 To 95
            For j = 0 To 95
                intensity(i, j) = 0
            Next
        Next
        NewProductLoc()
        quantity = iniQuantity
    End Sub

    Function NewTarget(cusNum As Integer)
        Select Case customers(cusNum, 6)
            Case 1
                Randomize()
NoProductToBuy:
                sum_pop = 0
                For i = 0 To validProduct.Length / 2 - 1
                    If validProduct(i * 2) > 0 Then
                        sum_pop += validProduct(i * 2 + 1)
                    End If
                Next
                Dim Posibility = rnd.NextDouble * sum_pop
                Dim ins_sum_pop As Double = 0
                For i = 0 To validProduct.Length / 2 - 1
                    If validProduct(i * 2) > 0 Then
                        If ins_sum_pop <= Posibility And Posibility < ins_sum_pop + popularity(validProduct(i * 2)) Then
                            customers(cusNum, 4) = validProduct(i * 2)
                            If quantity(customers(cusNum, 4)) = 0 Then
                                GoTo NoProductToBuy
                            Else
                                quantity(customers(cusNum, 4)) -= 1
                                Return {ProductLoc(validProduct(i * 2 - 1), 0), ProductLoc(validProduct(i * 2 - 1), 1)}
                                Exit Function
                            End If
                        Else
                            ins_sum_pop += popularity(validProduct(i * 2))
                        End If
                    End If
                Next
                MsgBox("New Target Error")
            Case 2
                Dim iniLoc(1)
                iniLoc(0) = 7 + Math.Round(rnd.NextDouble * 10)
                iniLoc(1) = 82 + Math.Round(rnd.NextDouble * 12) - 6
                Return iniLoc
            Case 3
                Dim iniLoc
                iniLoc = 54 + Math.Round(rnd.NextDouble * 12)
                Return {iniLoc, 95}
            Case Else
                MsgBox("New Target Error")
                Return {64, 95}
        End Select
    End Function
    Sub Ini() Handles Me.Load
        readFrom_csv()
        popularity_calc()
        extract_bmp()
        Dim acc = 0
        For i = 0 To 95
            For j = 0 To 95
                intensity(i, j) = 0
            Next
        Next
        For i = 1 To 94
            For j = 1 To 94
                Dim condition = False
                condition = (placement(i, j) = True And
                        (placement(i - 1, j) = False Or placement(i + 1, j) = False Or
                        placement(i, j - 1) = False Or placement(i, j + 1) = False))
                If condition Then
                    Array.Resize(Of Object)(validProductLoc, acc + 2)
                    validProductLoc(acc) = i
                    validProductLoc(acc + 1) = j
                    acc += 2
                End If
            Next
        Next
        RefreshImg()
        For i = 0 To 133
            damageList(i) = 0
            validProduct(2 * i) = i
            validProduct(2 * i + 1) = popularity(i)
        Next
        NewProductLoc()
        dgvFilling()
    End Sub

    Sub dgvFilling()
        For i = 0 To 133
            dgvResult.Rows.Add()
            dgvResult.Rows(i).Cells(0).Value = i + 1
            dgvResult.Rows(i).Cells(1).Value = ProductLoc(i, 0).ToString & ", " & ProductLoc(i, 1).ToString
            dgvResult.Rows(i).Cells(2).Value = quantity(i)
            dgvResult.Rows(i).Cells(6).Value = Math.Round(popularity(i), 2)
        Next
    End Sub

    Sub RefreshImg()
        Dim imgArray As New Bitmap(768, 768)
        For x = 0 To 95
            For y = 0 To 95
                If placement(x, y) Then
                    For i = 0 To 7
                        For j = 0 To 7
                            For k = 0 To 2
                                imgArray.SetPixel(x * 8 + i, y * 8 + j, Color.Black)
                            Next
                        Next
                    Next
                Else
                    For i = 0 To 7
                        For j = 0 To 7
                            For k = 0 To 2
                                imgArray.SetPixel(x * 8 + i, y * 8 + j,
                                                  Color.FromArgb(255, 255 - intensity(x, y) * 10, 255 - intensity(x, y) * 10))
                            Next
                        Next
                    Next
                End If
            Next
        Next
        picMain.Image = imgArray
        picMain.SizeMode = AutoSizeMode
    End Sub

    Sub readFrom_csv()
        Dim fileReader = My.Computer.FileSystem.ReadAllText(
    "C:\Users\qo\source\repos\2020 IMMC Flash Sales _Form\2020 IMMC Flash Sales _Form\bin\Debug\StoreData_IMMC.csv")
        Dim file = fileReader.ToString
        Dim str(1205)
        Dim acc = 0
        Dim TempStr = ""
        For i = 0 To file.Length - 1
            Dim character As Char = file(i)
            If character = "," Then
                str(acc) = TempStr
                TempStr = ""
                acc += 1
            Else
                TempStr &= character
            End If
        Next
        For i = 0 To 133
            order(i) = str(i * 9)
            department(i) = str(i * 9 + 1)
            category(i) = str(i * 9 + 2)
            type(i) = str(i * 9 + 3)
            brand(i) = str(i * 9 + 4)
            iniPrice(i) = str(i * 9 + 5)
            finPrice(i) = str(i * 9 + 6)
            quantity(i) = str(i * 9 + 7)
            rating(i) = str(i * 9 + 8)
        Next

        fileReader = My.Computer.FileSystem.ReadAllText(
    "C:\Users\qo\source\repos\2020 IMMC Flash Sales _Form\2020 IMMC Flash Sales _Form\bin\Debug\Product Names.csv")
        acc = 0
        TempStr = ""
        file = fileReader.ToString
        For i = 1 To file.Length - 1
            Dim character As String = file(i)
            If character = "|" Then
                nameOfProduct(acc) = TempStr
                TempStr = ""
                acc += 1
            Else
                TempStr &= character
            End If
        Next
    End Sub

    Function walk(cusNum)
        Dim x = customers(cusNum, 0)
        Dim y = customers(cusNum, 1)
        Dim x_target = customers(cusNum, 2)
        Dim y_target = customers(cusNum, 3)
        If x = x_target And y = y_target Then
            Return {x, y}
        ElseIf x = x_target Then
            Dim i = （y_target - y） / Math.Abs(y_target - y)
            If placement(x, y + i) = False Then
                Return {x, y + i}
            Else
                GoTo AnotherCondition
            End If
        ElseIf y = y_target Then
            Dim i = （x_target - x） / Math.Abs(x_target - x)
            If placement(x + i, y) = False Then
                Return {x + i, y}
            Else
                GoTo AnotherCondition
            End If
        Else
AnotherCondition:
            Dim shortestDistance As Single(,) = {{-2, -2, 999999}, {-2, -2, 999999}, {-2, -2, 999999}} 'x, y, index
            For i = -1 To 1
                For j = -1 To 1
                    If x + i = x_target And y + j = y_target Then
                        Return {x_target, y_target}
                        Exit Function
                    End If
                    Dim d
                    If barrier(x + i, y + j) Then
                        d = 9999999
                    Else
                        d = distance(x + i, y + j, x_target, y_target)
                    End If
                    Try
                        Select Case intensity(x + i, y + j)
                            Case 2
                                d = d
                            Case 1
                                d *= 2 / 3
                            Case 0
                                d /= 3
                            Case Else
                                d = 9999999
                        End Select
                    Catch ex As Exception
                    End Try
                    For k = 0 To 2
                        If d < shortestDistance(k, 2) Then
                            shortestDistance(k, 0) = i
                            shortestDistance(k, 1) = j
                            shortestDistance(k, 2) = d
                            GoTo distanceEnlisted
                        End If
                    Next
distanceEnlisted:
                Next
            Next
            Dim highestIndex As Single() = {-2, -2, -1}
            For k = 0 To 2
                If Val(shortestDistance(k, 2)) ^ (-1) >
                    highestIndex(2) Then
                    highestIndex(0) = shortestDistance(k, 0)
                    highestIndex(1) = shortestDistance(k, 1)
                    highestIndex(2) = shortestDistance(k, 2)
                End If
            Next
            If (Not customers(cusNum, 4) = -1) And (customers(cusNum, 6) = 2 Or customers(cusNum, 6) = 3) Then
                Randomize()
                If x <> 64 And y <> 95 Then
                    If intensity(x, y) / 400 >= rnd.NextDouble Then
                        If Not customers(cusNum, 5) = 1 Then
                            If customers(cusNum, 6) > 1 Then
                                customers(cusNum, 5) = 1
                                damageList(customers(cusNum, 4)) += 1
                            End If
                        End If
                    End If
                End If
            End If
            Return {x + highestIndex(0), y + highestIndex(1)}
            End If
    End Function

    Function distance(x, y, x_target, y_target) As Double
        Dim d = ((y_target - y) ^ 2 + (x_target - x) ^ 2) ^ (1 / 2)
        Return d
    End Function

    Function barrier(x, y) As Boolean
        If x < 0 Or x > 95 Or y < 0 Or y > 95 Then
            Return True
        ElseIf placement(x, y) Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub popularity_calc()
        For i = 0 To 133
            popularity(i) =
(1 - finPrice(i) / iniPrice(i)) * 2.79 ^ rating(i) * (11.4552239 / quantity(i)) ^ 0.5
            sum_pop += popularity(i)
        Next
        For i = 0 To 133
            For j = 0 To departments.Length / 3 - 1
                If department(i) = departments(j, 0) Then
                    departments(j, 1) += 1
                    departments(j, 2) += popularity(i)
                    GoTo departmentSearched
                End If
                If j = departments.Length / 3 - 1 Then
                    MsgBox("Department error")
                End If
            Next
departmentSearched:
            For j = 0 To categories.Length / 3 - 1
                If category(i) = categories(j, 0) Then
                    categories(j, 1) += 1
                    categories(j, 2) += popularity(i)
                    GoTo categorySearched
                End If
                If j = categories.Length / 3 - 1 Then
                    MsgBox("Category error")
                End If
            Next
categorySearched:
            For j = 0 To types.Length / 3 - 1
                If type(i) = types(j, 0) Then
                    types(j, 1) += 1
                    types(j, 2) += popularity(i)
                    GoTo typeSearched
                End If
                If j = types.Length / 3 - 1 Then
                    MsgBox("Type error")
                End If
            Next
typeSearched:
            For j = 0 To brands.Length / 3 - 1
                If brand(i) = "Brand " & brands(j, 0) Then
                    brands(j, 1) += 1
                    brands(j, 2) += popularity(i)
                    GoTo brandSearched
                End If
                If j = brands.Length / 3 - 1 Then
                    MsgBox("Brand error")
                End If
            Next
brandSearched:
        Next
        For i = 0 To 133
            For j = 0 To departments.Length / 3 - 1
                If department(i) = departments(j, 0) Then
                    popularity(i) += departments(j, 2) / departments(j, 1) ^ 2
                    GoTo departmentModerated
                End If
            Next
departmentModerated:
            For j = 0 To categories.Length / 3 - 1
                If category(i) = categories(j, 0) Then
                    popularity(i) += categories(j, 2) / categories(j, 1) ^ 2
                    GoTo categoryModerated
                End If
            Next
categoryModerated:
            For j = 0 To types.Length / 3 - 1
                If type(i) = types(j, 0) Then
                    popularity(i) += types(j, 2) / types(j, 1) ^ 2
                    GoTo typeModerated
                End If
            Next
typeModerated:
            For j = 0 To brands.Length / 3 - 1
                If brand(i) = brands(j, 0) Then
                    popularity(i) += brands(j, 2) / brands(j, 1) ^ 2 / 4
                    GoTo brandModerated
                End If
            Next
brandModerated:
        Next
    End Sub

    Sub extract_bmp()
        Dim path As String
        If figure = 1 Then
            path = "C:\Users\qo\source\repos\2020 IMMC Flash Sales _Form\2020 IMMC Flash Sales _Form\bin\Debug\Figure 1.bmp"
        Else
            path = "C:\Users\qo\source\repos\2020 IMMC Flash Sales _Form\2020 IMMC Flash Sales _Form\bin\Debug\Figure 2.bmp"
        End If

        Dim img As New Bitmap(path)
        For x0 = 0 To 95
                For y0 = 0 To 95
                    Dim pixelNeeded = 0
                    For i = 0 To 9
                        For j = 0 To 9
                        Dim x = x0 * img.Width / 96 + i * img.Width / 96 / 9
                        Dim y = y0 * img.Height / 96 + j * img.Height / 96 / 9
                        If x > img.Width - 1 Then
                            x = img.Width - 1
                        End If
                        If y > img.Height - 1 Then
                            y = img.Height - 1
                        End If
                        If img.GetPixel(Math.Round(x, 0),
                                            Math.Round(y, 0)) =
                                Color.FromArgb(102, 102, 102) Then
                                pixelNeeded += 1
                            End If
                        Next
                    Next
                    If pixelNeeded >= 50 Then
                        placement(x0, y0) = True
                    Else
                        placement(x0, y0) = False
                    End If
                Next
            Next
    End Sub

    Function cleared()
        For i = 0 To customers.Length / 7 - 1
            If customers(i, 6) <> 4 Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Sub NewProductLoc()
        Randomize()
        Dim departmentLoc
        If figure = 2 Then
            departmentLoc = {{"Appliances", 28, 46}, {"Audio", 64, 6},
                {"Cell Phones", 88, 68}, {"Computers&Tablets", 88, 24},
                {"TV&Home Theater", 21, 18}, {"Popular", 65, 49}}
        Else
            departmentLoc = {{"Appliances", 18, 23}, {"Audio", 47, 1},
                {"Cameras", 94, 41}, {"Cell Phones", 41, 94},
                {"Computers&Tablets", 57, 23}, {"TV&Home Theater", 57, 55},
                {"Video Gaming", 18, 55}}
        End If
        For i = 0 To 133
            If figure = 2 Then
                Select Case department(i)
                    Case "Cameras"
                        department(i) = "Audio"
                    Case "Video Gaming"
                        department(i) = "Cell Phones"
                End Select
                If popularity(i) > 82.16 Then
                    department(i) = "Popular"
                End If
            End If
            Dim temp = -1
            For k = 0 To departmentLoc.length / 3 - 1
                If department(i) = departmentLoc(k, 0) Then
                    temp = k
                End If
            Next
TooLongRange:
            Dim j = Math.Round(rnd.NextDouble * (validProductLoc.Length / 2 - 1))
            ProductLoc(i, 0) = validProductLoc(j)
            ProductLoc(i, 1) = validProductLoc(j + 1)
            Dim departmentRange
            If figure = 1 Then
                departmentRange = 20
            Else
                departmentRange = 20
            End If
            If distance(ProductLoc(i, 0), ProductLoc(i, 1), departmentLoc(temp, 1), departmentLoc(temp, 2)) > departmentRange Then
                GoTo TooLongRange
            End If
        Next
    End Sub
End Class
