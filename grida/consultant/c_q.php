
<?php
   include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
   session_start();
 ?>
<html>
<head>
<title>P1 질문</title>
</head>
<meta name="viewport" http-equiv="Content-Type" content="text/html;charset=utf-8; width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no" />
<body topmargin=0 leftmargin=0 text=#464646>
<meta http-equiv="Content-Type" content="text/html; charset=euc-kr">
<link rel="stylesheet" type="text/css" href="../css/htp/p_q1_style.css">
<script src="http://code.jquery.com/jquery-1.8.3.js"></script>
<script>
/*질문 폼체크 
function formCheck()
{
      for(var i=1;i<=8;i++)
       {
        var id= "#p_q"+i;
        var ptn=/^[a-zA-Z0-9._가-힣]{2,999}$/;
        var msg="#p_q"+i+"입력이안됨";
         if(!check_item(id,ptn,msg)){
            return false;
          }
       }
      function check_item(id,ptn,msg)
      {
         var val = $(id).val();
         if(!ptn.test(val)){
            alert(msg);
            $(id).focus();
            return false;
         }
         return true;
       }
} -->
</script>
<body>      
    <header>
        <div id="return">
        <a href="p1_test.html">
            <img src="../img/화살표2.png"/>
        </a>
        </div>
        <div id="rogo"><img src="../img/logowhite.png"></div>
        <div id="title">사람 질문</div>
    </header>
    <section>
        <div id="explan">
            질문에 있는 대답을 있는 그대로 솔직하게 대답해 주세요.
        </div>
    <form  action = "p_q1.php" method = "post" onsubmit="return formCheck();">
        <!-- 입력 부분 -->
        
        <div id="id" class="head">
            <div id="id_1" class="head_1">
            아 이 디
            <? echo $_SESSION["myAdmin"];?>
            </div>
        </div>

        <div id="time" class="head">
            <div id="time_1" class="head_1">        
            소요시간
            </div>
            <div id="time_2" class="head_2">
            <? echo $_SESSION["timecoms"];?>
            </div>     
        </div>
            <!-- 입력 부분 시작 -->
           <div id="question">
                <div class = "question" id="q1">
                    <div class = "question_1">
                           <h3>질문 1</h3>
                           <h2>이 사람은 누구인가요?</h2>
                    </div>

                    <div class = "question_2">
                           <TEXTAREA class = "area" name = p_q1 id =p_q1 placeholder = 'ex)저 입니다.'></TEXTAREA>
                    </div>
                </div>

                <div class = "question" id="q2">
                    <div class = "question_1">
                        <h3>질 문 2</h3>
                        <h2>이 사람의 나이는 몇 살인가요?</h2>
                    </div>

                    <div class = "question_2">       
                        <TEXTAREA class = "area" name = p_q2 id =p_q2 placeholder = 'ex)10살입니다.'></TEXTAREA>
                    </div>
                </div>

                <div class = "question" id="q3">
                    <div class = "question_1">
                        <h3>질 문 3</h3>
                        <h2>이 사람은 무엇을 하는 걸까요?</h2>
                    </div>

                    <div class = "question_2">      
                        <TEXTAREA class = "area" name = p_q3 id =p_q3 placeholder = 'ex)친구들과 놀고있어요.'></TEXTAREA>
                    </div>
                </div>

                <div class = "question" id="q4">
                    <div class = "question_1">
                        <h3>질 문 4</h3>
                        <h2>이 사람의 무엇을 생각하고 있을까요?</h2>
                    </div>

                    <div class = "question_2">
                        <TEXTAREA class = "area" name = p_q4 id =p_q4 placeholder = 'ex)친구들과 어떤 이야기를 할지 생각하고 있어요.'></TEXTAREA>
                    </div>
                </div>

                <div class = "question" id="q5">
                    <div class = "question_1">
                        <h3>질 문 5</h3>
                        <h2>이 사람의 기분은 어떨까요?</h2>
                    </div>

                    <div class = "question_2">
                        <TEXTAREA class = "area" name = p_q5 id =p_q5 placeholder = 'ex)매우 행복합니다.'></TEXTAREA>
                    </div>
                </div>

                <div class = "question" id="q6">
                    <div class = "question_1">
                        <h3>질 문 6</h3>
                        <h2>이 사람은 나중에 어떻게 될까요?</h2>
                    </div>

                    <div class = "question_2">
                        <TEXTAREA class = "area" name = p_q6 id =p_q6 placeholder = 'ex)선생님이 될거에요.'></TEXTAREA>
                    </div>
                </div>

                 <div class = "question" id="q7">
                    <div class = "question_1">
                        <h3>질 문 7</h3>
                        <h2>이 사람은 나중에 어떻게 될까요?</h2>
                    </div>

                    <div class = "question_2">
                        <TEXTAREA class = "area" name = p_q7 id =p_q7 placeholder = 'ex)축구 선수가 될거에요.'></TEXTAREA>
                    </div>
                </div>
            </div>
                
            <!-- 입력 부분 끝 -->
        <div id="footer">
            <div id="footer_1">
                    <INPUT type=reset value="다 시 쓰 기" outline = none>
                    <INPUT type=submit value="다 음 상 담">
            </div>
        </div>
        </form>

    </section>
