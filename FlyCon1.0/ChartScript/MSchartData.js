var randomScalingFactor = function () { return Math.round(Math.random() * 100) };


//var a=["January","February","March","April","May","June","July"];
     
var Xdata;
var Ydata;


function CallChart(id, Xvalue, Yvalue)
{
    
    Xdata = Xvalue.split(',');
    Ydata = Yvalue.split(',');
   


    var barChartData = {

        labels: Xdata,
        datasets: [
            {
               

                fillColor: "#FF8330",
                strokeColor: "#E65C00",
            highlightFill: "#FF6600",
                highlightStroke: "#FF8330",
                data: Ydata
            }

        ]

    }
    var ctx = document.getElementById("canvas").getContext("2d");
    window.myBar = new Chart(ctx).Bar(barChartData, {
        responsive: true


    });

}


var randomScalingFactor = function () { return Math.round(Math.random() * 100) };




var Xdata;
var Ydata;


function CallChartGraph(id, Xvalue, Yvalue) {

    Xdata = Xvalue.split(',');
    Ydata = Yvalue.split(',');

   

    var barChartData = {

        labels: Xdata,
        datasets: [
            {

              
                fillColor: "#FFA3A3",
                strokeColor: "#FF9999",
                highlightFill: "#FF6666",
                highlightStroke: "#FFA3A3",
              
                data: Ydata
            }

        ]

    }
    var ctx = document.getElementById("barchart").getContext("2d");
    window.myBar = new Chart(ctx).Bar(barChartData, {
        responsive: true


    });

}



 