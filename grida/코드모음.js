     

특정 시간 부터 시,분,초를 realtime으로 감소시키는 javascript code를 따라해 보자.




<script type="text/javascript">

window.onload = function()

{

  d_timer();

}

window.onunload = function()

{

  clearTimeout(timer);

}

var timer   = setInterval(function() {

  d_timer()

  }, 1000);

var hour  = {$time['H']};    //    초기치(시간)

var minute  = {$time['i']};    //    초기치(분)

var second  = {$time['s']};    //    초기치(초)



function d_timer()

{

  second--;

  if ( 0 > second )

  {

    if ( 0 >= minute )

    {

      if ( 0 >= hour )

        clearTimeout(timer);

      else

      {

        hour--;

        minute  = 59;

        second  = 59;

      }

    } else

    {

      minute--;

      second  = 59;

    }

  }

  

  if ( 0 > second )

    second  = 0;

  

  html_hour = document.getElementById('hour');

  if ( 0 != hour )

    html_hour.innerHTML = "<span>" + hour + "</span><span>시간</span>";

  html_minute = document.getElementById('minute');

  if ( 0 != second )

    html_minute.innerHTML = "<span>" + minute + "</span><span>분</span>";

  html_second = document.getElementById('second');

  html_second.innerHTML = "<span>" + second + "</span><span>초</span>";

}

</script>

   function save()
   {
    document.frm.target="upload";
    document.frm.action="../php/image_save.php";
    document.frm.submit();
  }




출처: http://seungngil.tistory.com/entry/JavascriptTimerStopwatch예제-따라하기 [To be a programmer...]



     <input type="text" id="u_email2" name="u_email2" value="" readonly="readonly" />
        <select id="u_email3" name="u_email3" onchange="email3(this.form)">
         <option value ="naver.com">naver.com</option>
         <option value="gmail.com">gmail.com</option>
         <option value="daum.net">daum.net</option>
         <option value="0">직접입력</option>
       </select>



       <script>
$(document).ready(function(){                   // jquery load
    $("#idcheck").click(function(){                // idcheck라는 id를 가진 버튼이 클릭이 되면
       var id_val = $("#insert_id").val();         // insert_id라는 id를 가진 input의 값을 id_val이란 변수에 입력
$ajax({ // ajax 호출
          url: '12_01_idcheck.php?id='+id_val;          //12_01_idcheck.php?id={id_val에 입력된 값} 를 GET방식으로 호출 
type: 'GET',
                    success: funtion(data)
                    {
                         if(data == 'Y') {      //리턴이 Y이면,
                             alert('이 아이디는 생성할 수 있습니다.;);
                             exit;
                         } else {    // 리턴이 N이면,
                             alert('아이디가 중복됩니다.');
                             exit;
                         }
                    }
              });
        });
   });
</script>

<?

  if(empty($_POST['u_id']))
    {
      $id="";
      echo("아이디를 입력하세요.");
    }
    else
    {
      $id=$_POST['u_id'];
      include"DB.php";
      $sql="select * from myhome where id='$id' ";
      $result=mysql_query($sql);
      $num_record=mysql_num_rows($result);
       if($num_record)
       {
           echo "아이디가 중복됩니다.<br>";
           echo "다른 아이디를 사용하세요.<br>";
        }
        else
        {
            echo "사용가능한 아이디 입니다.";
         }

  mysql_close();
    }

 

?>


function id_check(){ 
   //아이디 중복확인 
     $.ajax({ 
            type:"POST", 
           //url:"./member/member_idcheck.jsp",     
            url:"member.php", //아작스 서버 주소 파일명 
            data: {"uid":'#uid'},  //좌측 joinid 피라미터 이름에 우측 $joinid변수값을 저장 
            datatype:"post",//서버의 실행된 결과값을 사용자로 받아오는 방법 
            success: function (data) {//success는 아작스로 받아오는것이 성공했을경우 
               //서버 데이터를 data변수에 저장 
               if(data==1){//중복 아이디가 있다면 
                $newtext='<font color="red" size="3"><b>중복 아이디입니다.</b></font>'; 
                $("#idcheck").text(''); 
                  $("#idcheck").show(); 
                  $("#idcheck").append($newtext);           
                    $("#uid").val('').focus(); 
                    return false; 
                 
                  }else{//중복 아이디가 아니면 
                var newtext='<font color="blue" size="3"><b>사용가능한 아이디입니다.</b></font>'; 
                $("#idcheck").text(''); 
                $("#idcheck").show(); 
                $("#idcheck").append(newtext); 
                $("#uid").focus(); 
               }           
      }, 
      error:function(){ 
             alert("data error"); 
        } 
       });//$.ajax 
} 

<?php 
// 아이디 중복체크 
$sql = sprintf(" SELECT COUNT(*) AS count FROM smart_users WHERE user_id = '%s' ", $user_id); 
// 이메일 중복체크 
$sql = sprintf(" SELECT COUNT(*) AS count FROM smart_users WHERE user_email = '%s' ", $user_email); 
// 닉네임 중복체크 
$sql = sprintf(" SELECT COUNT(*) AS count FROM smart_users WHERE user_nick = '%s' ", $user_nick); 
?> 


<?
 if(!$_GET['id']){
  echo("ID를 입력하세요.");  
 }
 else
 {
  $dbcon=mysql_connect("localhost","root","apmsetup");
  mysql_select_db('shop',$dbcon);
  $sql="SELECT * FROM wjdqh WHERE id={$_GET['id']}";
  $result=mysql_query($sql,$dbcon);
  $count=@mysql_result($result,0,1);
   if($_GET['id']==$count){
    echo "사용가능함 ."; 
   }
   else{
    echo "{$_GET['id']}";
   }
  mysql_close();
 }
?>
<?php
   if(isset($_GET["email"])){
      $email=$_GET["email"];
      //localhost 의 exam 계정 exam 비번 exam DB 연결
      $connect=mysqli_connect("localhost","exam","exam","exam");
      //utf8로 설정
      mysqli_query($connect,"set names utf8");
      $sql="SELECT * FROM input WHERE email='$email'";
      $result=mysqli_query($connect,$sql);
      $rows=mysqli_num_rows($result);
      // 결과 레코드 세트에 존재하는 행의 수를 반환
      if($rows>0){
         echo "이메일이 중복됩니다";
      }
      else{
         echo "사용가능한 이메일입니다";
      }
      //strpos : 
   }

   mysqli_close($connect);
?>

echo "<script> alert('존재하지 않는 회원입니다.'); history.go(-1);</script>";


<?php

  $id = $_POST["u_id"];
  $pw = $_POST["u_pw"];

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "SELECT id FROM grida_member WHERE id = '$id'";
    $result = mysql_query($sql);
    $count = mysql_num_rows($result);
    echo $count."id";

    $num = 3;

    echo $num;


    if($num == 3)
    {
      $sql = "SELECT pw FROM grida_member WHERE pw = '$pw'";
      $result = mysql_query($sql);
      $count = mysql_num_row($result);
      echo $count."pw";
      if($count == 1)
      {
        session_start();
        $_SESSION["myAdmin"] = "$id";
        echo "<script> window.location.href='../sub/index.html';</script>";
      }
      else
      {
        echo "<script> alert('아이디 또는 비밀번호를 확인하세요');</script>";
      }
    }
    else
    {
      echo "<script> alert('존재하지 않는 회원입니다.');</script>";
    }

    echo $count."pw2";


?>


 document.location.href='../php/meil_confirm.php';

 var upload = document.getElementsByTagName('input')[0],
    holder = document.getElementById('holder'),
    state = document.getElementById('status');
if (typeof window.FileReader === 'undefined') {
  state.className = 'fail';
} else {
  state.className = 'success';
  state.innerHTML = ''; //이미지 바로 올리기
}