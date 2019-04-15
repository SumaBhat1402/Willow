<!DOCTYPE html>
<html>
<head>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
<meta charset=utf-8 />
<title>Willow Question-One</title>
</head>
<body>
In my life, I used the following web search engines:<br/>
<a href="//www.yahoo.com" >Yahoo!</a><br/>
<a href="//www.yahoo.com">AltaVista</a><br/>
<a href="//www.google.com">Google</a><br/>

<script type="text/javascript">
$( document ).ready(function() {
  registerHandlers()
});

function registerHandlers() {
  var as = $('a');
  for (var i = 0; i < as.length; i++) {	  
   $(as[i]).on('click',(function(j){
      return function()
      {
      	alert(j);
      	return false;
      }     	
     
   })(i))

  }
}
</script>
</body>

</html>
