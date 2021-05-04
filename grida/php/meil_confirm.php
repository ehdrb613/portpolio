<!doctype html>
<head>
    <title>그리다</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<script src="../js/jquery.js"></script>
<script language="javascript">

function check_confirm()
{
    var confirm = $("#u_confirm").val();
    $.get("confirm.php?confirm="+confirm, 
    function(data){
        if(data == "Y")
        {
            alert("인증되었습니다.");
            document.location.href='../sub/login.html';
        }
        else
        {
            alert("인증되지 않았습니다.");
        }


    });
}
</script>
</head>
<body>
<div class="row">
   <label for="confirm">
   <span class="required"></span>
   이메일 인증
   </label>
   <input type="text" id="u_confirm" name="u_confirm" value="" />
   <input type="button" value="이메일인증" onclick="check_confirm()">
</div>
</body>
</html>