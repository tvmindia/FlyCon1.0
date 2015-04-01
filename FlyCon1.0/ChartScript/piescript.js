var Xdata;
var Ydata;
//alert('ab');

function CallChartPie(id,Xvalue, Yvalue)
{
   

   
    Xdata = Xvalue.split(',');

    Ydata = Yvalue.split(',');
    //datacolor = color.split(',');
    var aar=[];
    var i;
    for( i=0;i<Ydata.length;i++)
    {
       // alert(Ydata[i]);
        aar[i] = parseFloat(Ydata[i]);

    }


   // alert(Ydata[0]);
    var pie = new RGraph.Pie({
        id: 'cvs',
        data: aar,
        options: {
            labels: {
                self: Xdata,

                sticks: {
                    self: true,
                    length: 15,


                }
            },

            tooltips: Xdata,
            radius: 100,

            colors: ['#FF3300', '#2EB8E6', '#00B800', '#B2B212'],
          background:"green",
            strokestyle: 'transparent',

            exploded: [15]
        }
    }).roundRobin()
    
  
}
