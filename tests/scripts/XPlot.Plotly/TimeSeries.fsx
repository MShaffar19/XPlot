﻿#r @"../../../bin/XPlot.Plotly/netstandard2.0/XPlot.Plotly.dll"

open XPlot.Plotly

// TESTED under CI now

// Date Strings
module Chart1 =

    let data =
        Scatter(
            x = ["2013-10-04 22:23:00"; "2013-11-04 22:23:00"; "2013-12-04 22:23:00"],
            y = [1; 3; 6]
        )

    data
    |> Plotly.Plot
    |> Plotly.Show
