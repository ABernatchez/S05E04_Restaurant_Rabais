# Décisions

Classes et interface jouant les rôles de contexte, de contrat Strategy et de stratégies concrètes:
- Contexte: CalculateurFacture
- Contrat Strategy: IStrategieRabais
- Stratégies concrètes: RabaisNul, RabaisFixe, RabaisFidelite, RabaisMultiple

Lien avec OCP:
- À place de modifier le code dans CalculateurFacture.CalculerTotal(), on a juste besoin d'ajouter une classe implémentant IStrategieRabais, ce qui est le principe OCP.

Emplacement proposé comme point de composition:
- Dans Program.cs

Justification de la composition:
- À cause de l'on devrait laisser la décisions de quelle stratégie choisir au projet principal qui est dans ce cas-ci le projet Terminal

Code d’assemblage qu’un projet Terminal pourrait employer:
```c#
IStrategieRabais rabais = ChooseRabais(); // ChooseRabais serait une méthode dans Program.cs
CalculateurFacture calculateurFacture = new(rabais);

decimal total = calculateurFacture.CalculerTotal(20m);

//...
```

Résultat de la commande Git `git log --oneline --graph --decorate --all`:
```bash
* 9d19dba (HEAD -> fonctionnalite/exercice-4-strategy, origin/fonctionnalite/exercice-4-strategy) Ajoute stratégie de rabais appliquant multiples rabais
* 690436f Délégation du calcul dans CalculateurFacture à IStrategieRabais
* 8427222 Ajoute les tests pour le calcul de rabais
* 825dc66 Ajoute une stratégie et des stratégies concrètes pour le calcul de rabais
* 6c0fb9c (origin/main, origin/dev, origin/HEAD, main, dev) Initial commit
```
- *Ne compte pas le commit pour DECISIONS.md*