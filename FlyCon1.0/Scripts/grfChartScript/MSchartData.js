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
               

                fillColor: "rgba(46, 171, 255,0.5)",
                strokeColor: "rgba(46, 171, 255,0.8)",
                highlightFill: "rgba(46, 171, 255,0.75)",
                highlightStroke: "rgba(46, 171, 255,1)",
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

              
                fillColor: "rgba(255, 163, 163,0.5)",
                strokeColor: "rgba(255, 163, 163,0.8)",
                highlightFill: "rgba(255, 163, 163,0.75)",
                highlightStroke: "rgba(255, 163, 163,1)",
              
                data: Ydata
            }

        ]

    }
    var ctx = document.getElementById("barchart").getContext("2d");
    window.myBar = new Chart(ctx).Bar(barChartData, {
        responsive: true


    });

}



 