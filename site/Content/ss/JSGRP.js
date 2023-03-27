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
    var nbr=document.getElementById("I");
    var dure=document.getElementById("J");
    var AA=document.getElementById("K");
    var BB=document.getElementById("L");
    var CC=document.getElementById("M");
    var DD=document.getElementById("N");
    var EE=document.getElementById("O");
    var FF=document.getElementById("P");
    var GG=document.getElementById("Q");
    var HH=document.getElementById("R");   
    var II=document.getElementById("S");
    if(Nom.value==""||Adresse.value==""||Responsable.value==""||secteur.value==""||tele.value==""||type.value==""||lieu.value==""||date.value==""||dure.value==""||nbr.value==""||AA.value==""||BB.value==""||CC.value==""||DD.value==""||EE.value==""||FF.value==""||GG.value==""||HH.value==""||II.value=="")
    {
        alert("Attention!!!!  Il faut remplir tous les champs!!!");
    }
    else
    {
        alert("Validation Réusssitt");
    }

}