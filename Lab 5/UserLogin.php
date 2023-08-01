
<html>
<head>
<script>
function validateForm() {
  let x = document.forms["login"]["email"].value;
  if (x == "") {
    alert("Email must be filled out");
    return false;
  }
}

function validateForm1() {
  let y = document.forms["login"]["password"].value;
  if (y == "") {
    alert("Password must be filled out");
    return false;
  }
}


</script>


<body class="bg-warning col-lg-11.5">


<form name="login" action="controller/login.php"  method="POST" enctype="multipart/form-data" onsubmit="return validateForm(),validateForm1()">
 
 

 <div class="container" style="width:400px;"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />  

    Email: <input type="text" name="email" class="form-control" placeholder="Enter your Email">
  <br><br>
  
  Password: <input type="password" name="password" class="form-control"placeholder="Enter your Password"> 
<br>
 <div style="text-align:center;">

 <input  type="submit" name="submit" value="Submit" class="btn btn-info" >  
</div>
 

<?php  
                     if(isset($message))  
                     {  
                          echo $message;  
                     }  
                     ?>  

                     <?php   
                     if(isset($error))  
                     {  
                          echo $error;  
                     }  
                     ?>
  

</form>



</div>
</body>
</html>
