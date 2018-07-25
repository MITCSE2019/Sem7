// if( document.getElementById("hour").value < 12 )
// {
// 	alert( "Morning!" );
// }
// else if( document.getElementById("hour").value > 12 && document.getElementById("hour").value < 15 )
// {
// 	alert( "Afternoon!" );
// }
// else if( document.getElementById("hour").value > 15 && document.getElementById("hour").value < 21 )
// {
// 	alert( "Evening!" );
// }
// else
// {
// 	alert( "Night!");
// }
setInterval(function()
{
	var temp = new Date();
	document.getElementById("hour").value = temp.getHours();
	document.getElementById("minutes").value = temp.getMinutes();
	document.getElementById("seconds").value = temp.getSeconds();
},1000);