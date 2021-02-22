function start(){
    var sty=document.getElementById("sty");
    var htp=document.getElementById("htp");
    if (sty=1) {
    	document.getElementById("tip").innerHTML = "사용자에게 적합한 치료는 \n HTP검사입니다.";
    }
    else{
      document.getElementById("tip").innerHTML = "사용자에게 적합한 치료는 \n 동적 가족화입니다.";
    }
  }
