$(document).ready(function(){
    if (!('url' in window) && ('webkitURL' in window)) {
        window.URL = window.webkitURL;
    }
 
    $('#camera').change(function(e){
        $('#pic').attr('src', URL.createObjectURL(e.target.files[0]));
    });
});