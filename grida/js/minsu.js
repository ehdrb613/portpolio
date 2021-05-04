function email3(userinput)
{
   var email3 = userinput.mem_email3.value;
   if (email3 == 0) 
   {
      userinput.mem_eamil2.value = '';
      userinput.mem_eamil2.readOnly = false;
   }
   else
   {
      userinput.mem_eamil2.value = email3;
      userinput.mem_eamil2.readOnly = true;
   }
}