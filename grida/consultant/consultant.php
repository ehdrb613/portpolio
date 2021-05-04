<?php
session_start();

function g($v){
	if(isset($_GET["$v"])){
		return $_GET["$v"];
	}
	return "";
}
$ord = g("ord");

$connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");
/*
    $name = $_POST["u_name"];
    $id = $_POST["u_id"];
    $pw1 = $_POST["u_pw1"];
    $tel = $_POST["u_tel"];
    $birthday = $_POST["u_birthday"];
    $email=$_POST["u_email"];
    
if(g("mode") =="insert"){
	$name=$_GET["name"];
	$sub1=$_GET["sub1"];
	$sub2=$_GET["sub2"];
	$sub3=$_GET["sub3"];
	$sub4=$_GET["sub4"];
	$sub5=$_GET["sub5"];
	$sum = $sub1 + $sub2 + $sub3 +$sub4 + $sub5;
	$avg = $sum / 5; 
*/
    

	if(g("mode") =="del"){
	$id=$_GET["id"];
	$sql = "DELETE FROM grida_h_t WHERE id='$id'";
	mysql_query($sql);
}

?>
<!DOCTYPE html>
<html>
<head>
	<title>그리다</title>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link href="../css/storage_style.css" rel="stylesheet" type="text/css"/>

	<script type="text/javascript">
		function del(i){
			if(confirm('정말로??')){
				location.href="?mode=del&ord=<?php echo $ord?>&id="+i;
			}
		}

		functionpage_move(s_page,s_name,s_value){
		    var f=document.paging; //폼 name
		  
		    f.src_name.value = s_name; //POST방식으로 넘기고 싶은 값
		    f.action="storage_view.php";//이동할 페이지
		    f.method="post";//POST방식
		    f.submit();
		}

	</script>

</head>
<body>
	
	<header>
    <div id="return">
    <a href="../">
      <img src="../img/화살표2.png"/>
    </a>
    </div>
    <div id="rogo"><img src="../img/logowhite.png"></div>
    <div id="title">보관함</div>
     </header>
	<!--<div>
		<a href="?ord=asc">[성적순 정렬]</a>&nbsp;&nbsp;&nbsp;
		<a href="?ord=desc">[성적역순 정렬]</a>
	</div>-->

    <aside id="C_aside">
    	<input id="1" type="radio" name="tab" checked="checked"/>
	    <input id="2" type="radio" name="tab"/>
	    <section class="buttons">
	    <label for="1">HTP 검사</label>
	    <label for="2">동적 가족화 검사</label>
	    </section>
      <div class="tab">
		<table>
		
<?php
	$v_id = $_SESSION["myAdmin"];
	$a=0;

	if ($_SESSION["myAdmin"] == "counselor1")
	{
		$cl_name = "손혜주";
	}
	else if ($_SESSION["myAdmin"] == "counselor2")
	{
		$cl_name = "상담사추가";
	}

	//여기에 select 쪽에 세션 받아서 id 비교하는거 넣어야됨
	$sql= "SELECT * FROM grida_h_t WHERE ok = '미등록'";
	if($ord == "asc"){
		$sql = "SELECT * FROM grida_h_t WHERE ok = '미등록' ORDER BY sum ASC";
	}
	if($ord == "desc"){
		$sql = "SELECT * FROM grida_h_t WHERE ok = '미등록' ORDER BY sum DESC";
	}

	$result = mysql_query($sql);
	if($result){
		while($row = mysql_fetch_assoc($result)){
			$num[$a]=$row["num"];

?>
		
		<tr class="clk">

				<td>
				<a href="board.php?id_num=<? echo $row["id"] ?>">
				<div class="main_text">
				<span>등록자 : <?echo $row["id"]?> &nbsp;&nbsp; |
				<span>검사종류 : HTP 검사 &nbsp;&nbsp; | &nbsp;&nbsp;</span>
				<span>담당상담사 : <?php echo $cl_name;?></span>
				</div>
				<div class="sub_text">
				<span>일시 : <?php echo $row["u_dt"]?> &nbsp;&nbsp;|&nbsp;&nbsp; </span>
				<span>답변여부 : <?php echo $row["ok"]?></span>
				</div>
				</a></td>
		</tr>	
				<!--<td><a href="#" onclick="del('<?php echo $row["id"]?>');return false">삭제</a></td>-->
		
<?php
	$a++;
		}
	}
?>
		
	</table>
	</div>



	<div class="tab">
	<table class="tab">
		
<?php
	$v_id = $_SESSION["myAdmin"];
	$a=0;

	//여기에 select 쪽에 세션 받아서 id 비교하는거 넣어야됨
	$sql= "SELECT * FROM grida_h_t WHERE id='$v_id'";
	if($ord == "asc"){
		$sql = "SELECT * FROM grida_h_t WHERE id='$v_id' ORDER BY sum ASC";
	}
	if($ord == "desc"){
		$sql = "SELECT * FROM grida_h_t WHERE id='$v_id' ORDER BY sum DESC";
	}

	$result = mysql_query($sql);
	if($result){
		while($row = mysql_fetch_assoc($result)){
			$num[$a]=$row["num"];

?>
		
		<tr class="clk">

				<td>
				<a href="storage_view.php?v_num=<? echo $num[$a] ?>">
				<div class="main_text">
				<span>검사종류 : 동적가족화 검사 &nbsp;&nbsp; | &nbsp;&nbsp;</span>
				<span>담당상담사 : cell</span>
				</div>
				<div class="sub_text">
				<span>일시 : <?php echo $row["u_dt"]?> &nbsp;&nbsp;|&nbsp;&nbsp; </span>
				<span></span>
				</div>
				</a></td>
		</tr>	
				<!--<td><a href="#" onclick="del('<?php echo $row["id"]?>');return false">삭제</a></td>-->
		
<?php
	$a++;
		}
	}
?>
		
	</table>
	</div>
		
	</aside>
</body>
</html>
<?php
mysql_close($connect);
?>