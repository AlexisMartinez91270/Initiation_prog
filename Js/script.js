let Main = function () {
  let myTab = InitTab();
  let myTabTri = TriCroissant(myTab);
  console.log("Tableau trié ----------------------");
  for (let i = 0; i < myTabTri.length; i++) {
    console.log(myTabTri[i]);
  }
};

function TriCroissant(tab) {
  let temp;
  for (let i = 0; i < tab.length - 1; i++) {
    for (let j = i + 1; j < tab.length; j++) {
      if (tab[i] > tab[j]) {
        temp = tab[i];
        tab[i] = tab[j];
        tab[j] = temp;
      }
    }
  }
  return tab;
}

function InitTab() {
  let tab = new Array(15);
  alert("Entrez 15 valeurs entières : ");
  for (let i = 0; i < tab.length; i++) {
    tab[i] = parseInt(prompt());
  }
  return tab;
}

window.onload = Main();
