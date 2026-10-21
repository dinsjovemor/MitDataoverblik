# Samarbejdslog

Loggen indeholder udvalgte opsummeringer af samarbejdet. Den er ikke en fuldstændig chatudskrift. Registreringstidspunkt og hændelsestidspunkt skelnes, når noten er skrevet bagefter.

## Hidtidigt forløb

Efterfølgende opsummering skrevet 15. oktober 2026. Præcise tidspunkter for de enkelte hændelser er ikke registreret her.

- Opgavekrav, projektbeskrivelse, backlog og sprintplan blev gennemgået med AI-støtte.
- Det tidligere arbejde i Professionel softwareudvikling blev sammenholdt med Blazor/Scrum-opgaven. Det eksisterende projekt genbruges, mens afleveringsforløbene holdes adskilt.
- Brugeren valgte at føre ugeplan og udvidet Kanban-board i hånden på reMarkable og samle billeder og begrundelser i sin historik.
- PB01 blev flyttet fra Up Next til In Progress. Tre simulerede myndigheder blev valgt: Silkeborg Kommune, Geodatastyrelsen og Klimadatastyrelsen.
- Seks fiktive oplysninger blev aftalt: folkeregisteradresse, tilflytningsdato, matrikelnummer, grundareal, breddegrad og længdegrad. Koblingen til myndighederne er en del af simuleringen.
- Brugeren oprettede modellen Borgeroplysning og indsatte kode med AI-støtte. Feedback på et skærmbillede identificerede et manglende semikolon. Brugeren rettede det. Feltnavnene Værdi og DataType blev fastholdt i den videre vejledning.
- Branchen feature/pb01-dataoverblik blev oprettet. Brugeren oprettede og gemte BorgeroplysningService med seks demodata og registrerede den i Program.cs efter vejledning.
- Komponenten Myndighedskort.razor blev oprettet som næste trin. På dette tidspunkt var den nye visning endnu ikke bygget og afprøvet; PB01 var derfor ikke færdig.

Disse punkter bygger på dialogen og brugerens tilbagemeldinger og er ikke en ny kontrol af kode, build eller tests.

## Dokumentationsmappe aftalt

Registreret: 15. oktober 2026 kl. 09.27, dansk tid.

- Emne: Synliggørelse af AI-støtte og feedback.
- Brugerens forslag: En mappe med samarbejdsaftale og relevante dialoger med tidspunkter.
- AI-forslag: Korte dokumenter med aftale, samarbejdslog og Scrum-møder i projektets Git-repository.
- Beslutning: Brugeren godkendte placeringen i Git og løbende opdatering af dokumentationen.
- Resultat: Dokumentationsmappen blev oprettet. Filerne er endnu ikke committed eller publiceret.

## Skabelon til kommende noter

- Dato og tidspunkt:
- Emne eller opgave:
- Brugerens spørgsmål eller eget forslag:
- AI-hjælp eller feedback:
- Brugerens beslutning:
- Resultat og eventuel afprøvning:
- Næste skridt:

## Samlet afprøvning den 20. oktober 2026

Efterfølgende opsummering fra dialogen samme dag, uden præcise hændelsestidspunkter.

- Den studerende gennemførte Release-build og eksisterende tests; skærmbilledet viste 2 beståede tests og ingen fejl.
- AI guidede trinvis gennem søgning, filtre, validering, oprettelse, shared state, brugeradskillelse, statusændringer og adgangskontrol.
- Den studerende rettede en testafklaring: søgning med små bogstaver var først prøvet, hvorefter ADRESSE med store bogstaver blev afprøvet særskilt. En anden afklaring var, at brugeren allerede stod på forsiden og derefter skulle klikke Se alle mine anmodninger.
- Brugeren bekræftede resultaterne undervejs og delte skærmbilleder. Afprøvningen er ikke en uafhængig teknisk audit fra AI.
- Resultater og kendte begrænsninger er samlet i Dokumentation/Slutkontrol-2026-10-20.md.
- Næste skridt er opgavekravsgennemgang og præsentationsforberedelse. Sprint 2 review og retrospective er fortsat planlagt til 21. oktober.

## Sprintafslutning og kommentarkontrol den 21. oktober 2026

Efterfølgende opsummering af dagens dialog, registreret kl. 23.12 dansk tid.

- Sprint 2 review og retrospective er gennemført og refereret i Scrum-moeder.md.
- Den studerende bad om en direkte sammenligning med opgavekravene. AI gennemlæste relevante dele af den aktuelle kode og sammenholdt dem med opgavekravene og tidligere afprøvninger. Der blev ikke kørt nye tests i denne sammenligning.
- Beslutning: Ingen nye funktioner; fokus på forståelse, dokumentation, øvelse og aflevering.
- Den studerende foreslog kommentarkontrol under kodegennemgangen som en ny forbedring. AI skal kontrollere korte forklarende kommentarer, så de bliver pålidelige hjælpelinjer. Kommentarer skrives uden punktum til sidst.
- Personlige oplysninger fra refleksionen er udeladt af referatet. Arbejdsform og læringsudbytte er bevaret.
- Opdateringerne er gemt lokalt. Commit og push er ikke udført som del af referatskrivningen.
