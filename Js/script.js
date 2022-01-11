let jours;
let mois;

do {
  mois = prompt("Saisir un numéro de mois");

  mois = Math.abs(mois - 7.5) - 0.5;

  if (mois > 6) {
    alert("Entre 1 & 12");
  } else {
    jours = mois % 2 == 0 ? 31 : mois == 5 ? 28 : 30;
  }
} while (mois > 6);

alert(jours);
