let montant;
let montantTTC;
let tauxRemise = 0;
montant = prompt("Saisir un montant");
montantTTC = montant * 1.196;
if (montantTTC >= 1000 && montantTTC < 2000) {
  tauxRemise = 1;
} else if (montantTTC >= 2000 && montantTTC < 5000) {
  tauxRemise = 2;
} else if (montantTTC >= 5000) {
  tauxRemise = 5;
}

montantTTC *= 1 - tauxRemise / 100;
alert(montantTTC);
