function valider()
{
    var Nom=document.getElementById("A");
    var Adresse=document.getElementById("B");
    var Responsable=document.getElementById("C");
    var secteur=document.getElementById("D");
    var tele=document.getElementById("E");
    var type=document.getElementById("F");
    var lieu=document.getElementById("G");
    var date=document.getElementById("H");
    // var nbr=document.getElementById("I");
    // var dure=document.getElementById("J");
    if(Nom.value==""||Adresse.value==""||Responsable.value==""||secteur.value==""||tele.value==""||type.value==""||lieu.value==""||date.value==""||dure.value==""||nbr.value=="")
    {
        alert("Attention!!!!  Il faut remplir tous les champs!!!");
    }
    else
    {
      document.write(window.location.href='../index.html');
    }

}