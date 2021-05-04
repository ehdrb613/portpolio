<?php
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
	$sql = "DELETE FROM grida_member WHERE id='$id'";
	mysql_query($sql);
}

?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>그리다</title>
	<style>
	 body{font-size:16px;}
	 
	 form{border:1px solid #999;
	 	padding:10px;
	 	width:850px;}
	 table{border-collapse:collapse; margin-top:10px;}
	 table,th,td{border:1px solid #aaa;}
	 th,td{padding:8px;}
	 th{background:#ccc;}
	</style>
	<script type="text/javascript">
		function del(i){
			if(confirm('정말로??')){
				location.href="?mode=del&ord=<?php echo $ord?>&id="+i;
			}
		}
	</script>
</head>
<body>
	
	<h4>보관함</h4>
	<!--<div>
		<a href="?ord=asc">[성적순 정렬]</a>&nbsp;&nbsp;&nbsp;
		<a href="?ord=desc">[성적역순 정렬]</a>
	</div>-->
	<table>
		<tr>
			<th>이름</th>
			<th>아이디</th>
			<th>비번</th>
			<th>전화번호</th>
			<th>생일</th>
			<th>이메일</th>
			<th>인증코드</th>
			<th>깃발</th>
			<th>삭제</th>
		</tr>
<?php
	$sql= "SELECT * FROM grida_member";
	if($ord == "asc"){
		$sql = "SELECT * FROM grida_member ORDER BY sum ASC";
	}
	if($ord == "desc"){
		$sql = "SELECT * FROM grida_member ORDER BY sum DESC";
	}

	$result = mysql_query($sql);
	if($result){
		while($row = mysql_fetch_assoc($result)){
?>
		<tr>
				<td><?php echo $row["name"]?></td>
				<td><?php echo $row["id"]?></td>
				<td><?php echo $row["pw"]?></td>
				<td><?php echo $row["birthday"]?></td>
				<td><?php echo $row["tel"]?></td>
				<td><?php echo $row["email"]?></td>
				<td><?php echo $row["e_confirm"]?></td>
				<td><?php echo $row["flag"]?></td>
				<td><a href="#" onclick="del('<?php echo $row["id"]?>');return false">삭제</a></td>
			</tr>
<?php

		}
	}
?>
		
	</table>
</body>
</html>
<?php
mysql_close($db);
?>