let Main = function () {
  let prix = 0,
    articles = 0,
    tva = 0;

  prix = DemandeBiggerThan0("Prix unitaire HT :", true);

  articles = DemandeBiggerThan0("Nombres articles :", true);

  tva = DemandeBiggerThan0("Taux TVA :", false);

  console.log("prix total HT: " + prix * articles);
  console.log("prix total TTC: " + prix * articles * (1 + tva * 0.01));
};

function ConvertitEnFloat(eu) {
  let f;
  try {
    f = parseFloat(eu);
  } catch (Exception) {
    console.log("Vous n'avez pas saisie un nombre");
    return -1;
  }

  return f;
}

function DemandeBiggerThan0(txt, strict) {
  let n;
  let mini = strict ? Number.EPSILON : 0;
  do {
    alert(txt);
    let eu = prompt();

    n = ConvertitEnFloat(eu);

    if (n < mini) {
      let ou_egal = "";
      if (!strict) ou_egal = " ou égal";
      alert("Veuillez saisir un nombre supérieur" + ou_egal + " à zéro");
    }
  } while (n < mini);

  return n;
}

window.onload = Main();
