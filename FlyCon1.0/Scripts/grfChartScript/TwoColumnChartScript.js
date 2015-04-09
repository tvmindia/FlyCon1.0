var randomScalingFactor = function () { return Math.round(Math.random() * 100) };



//var a=["January","February","March","April","May","June","July"];

var Xdata;
var Ydata;
var Y2data;

function CallChart(id,Xvalue, Yvalue, Y2value) {
 
    Xdata = Xvalue.split(',');
    Ydata = Yvalue.split(',');
    Y2data = Y2value.split(',');
    var barChartData = {
        labels: Xdata,
        datasets: [
            {


                fillColor: "rgba(255, 153, 153,0.5)",
                strokeColor: "rgba(255, 153, 153,0.8)",
                highlightFill: "rgba(255, 153, 153,0.75)",
                highlightStroke: "rgba(255, 153, 153,1)",
                data: Ydata
            },
             {

                 fillColor: "rgba(151,187,205,0.5)",
                 strokeColor: "rgba(151,187,205,0.8)",
                 highlightFill: "rgba(151,187,205,0.75)",
                 highlightStroke: "rgba(151,187,205,1)",
                 data: Y2data
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


function CallChart1(id,Xvalue, Yvalue, Y2value) {
   
    Xdata = Xvalue.split(',');
    Ydata = Yvalue.split(',');
    Y2data = Y2value.split(',');
 


    var barChartData = {

        labels: Xdata,
        datasets: [
            {


                fillColor: "#FF9999",
                strokeColor: "#FF9999",
                highlightFill: "rgba(220,220,220,0.75)",
                highlightStroke: "rgba(220,220,220,1)",
                highlightColor: '#669999',
                data: Ydata
            }
           
       

        ]

    }
    var ctx = document.getElementById("barchart").getContext("2d");
    window.myBar = new Chart(ctx).Bar(barChartData, {
        responsive: true


    });

}



