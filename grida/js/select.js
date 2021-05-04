function email3(userinput)
{
   var email3 = userinput.u_email3.value;
   if (email3 == "0") 
   {
      userinput.u_email2.value = '';
      userinput.u_email2.readOnly = false;
   }
   else
   {
      userinput.u_email2.value = email3;
      userinput.u_email2.readOnly = true;
   }
}