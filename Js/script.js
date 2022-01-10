let montant;
let tauxRemise = 0;
montant = prompt("Saisir un montant");
if (montant > 2000) {
  tauxRemise = 1.0;
  montant *= 1.0 - tauxRemise / 100.0;
}
console.log(montant);
