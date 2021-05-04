function timecom()
{

    if(running == 0)
    {
   running = 1;
   }
   else 
   {
   running = 0;
   document.getElementById("startPause").innerHTML = "재시작"
   }
    var time = document.getElementById("output").value;
    var times = time;
    $.get("timecom.php?timecom="+times, 
    function(data){
    if(data == "N")
    {
        var rkd = 1;
    }
  
    })
    alert("소요시간은 " + time + " 입니다.");
    
}
