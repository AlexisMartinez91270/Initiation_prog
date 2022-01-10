let jours;
let mois;
mois = prompt("Saisir le numéro d'un mois");
if (mois == 2) {
  jours = 28;
} else if (mois <= 7) {
  if (mois % 2 == 1) {
    jours = 31;
  } else {
    jours = 30;
  }
} else {
  if (mois % 2 == 0) {
    jours = 31;
  } else {
    jours = 30;
  }
}
alert(jours);
