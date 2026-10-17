# Mødekladde om roller og overgang mellem sprints

Klargjort 16. oktober 2026. Status: Kladde. Mødet er ikke gennemført. Spørgsmål og forslag nedenfor er ikke vedtagne beslutninger. Faktisk mødedato og tidspunkt tilføjes ved mødet.

Formålet er at samle op på PB01–PB03, afklare resterende arbejde og aftale arbejdsformen og målet for næste sprint. Vi gennemgår ét punkt ad gangen med plads til brugerens egne forklaringer.

## Rollefordeling i projektet

Projektet gennemføres af én studerende med AI-støtte. Det er en tilpasning inspireret af Scrum og ikke et fuldt Scrum-team.

- Produktansvar: Den studerende vælger målgruppe, prioriterer backlog og træffer de endelige produktbeslutninger. AI bidrager med spørgsmål, forslag og overblik. Underviseren fastlægger og afklarer opgavekravene.
- Udvikling: Den studerende implementerer, afprøver og har ansvar for at forstå og forklare løsningen. AI hjælper med kodeforslag, forklaringer, fejlfinding og feedback. Omfanget af hjælpen beskrives åbent.
- Procesansvar: Den studerende ejer planen og tilpasser arbejdsformen. AI understøtter med mødespørgsmål, statuslinjer, påmindelser i samtalen og udkast til noter.
- AI er ikke et selvstændigt Scrum-teammedlem, en formel Scrum Master eller en uafhængig menneskelig reviewer. Flere perspektiver kan anvendes i samtalen, men ansvaret overføres ikke til AI.

Spørgsmål: Beskriver dette den faktiske arbejdsdeling? Hvilke beslutninger og opgaver vil den studerende selv tage mere initiativ til fremover?

## Kort status før mødet

Ifølge den hidtidige dialog er PB01, PB02 og PB03 merged, manuelt afprøvet i de beskrevne scenarier og markeret Done. PB04 er oprettet som Issue #6 og sat til Doing; branchen feature/6-mine-anmodninger er oprettet. PB04-kodearbejdet er sat på pause for denne opsamling. Dette er en opsummering af dialogen, ikke en ny teknisk kontrol.

Den oprindelige plan placerede PB01–PB03 i sprint 1 og PB04–PB06 i sprint 2. Vi skal aftale og dokumentere de faktiske sprintgrænser, da arbejdet er nået hurtigere frem end planen. Vi daterer ikke et møde bagud eller beskriver det som allerede afholdt.

## Sprint 1 review om produktet

Oprindeligt mål: Se og finde fiktive borgeroplysninger og oprette en simuleret rettelsesanmodning.

1. Den studerende viser dataoverblik, søgning og filtre samt formular og validering.
2. Gennemgå acceptkriterier for PB01, PB02 og PB03. Skeln mellem demonstreret adfærd, tidligere afprøvning og forhold der endnu ikke er kontrolleret.
3. Følg op på PB03: Kan ID, borger, oplysning, dato og status genfindes efter oprettelse? Visning på tværs af sider og link til Mine anmodninger er endnu ikke færdiggjort og afprøvet.
4. Aftal hvor resterende arbejde registreres. Done i Azure Boards er ikke i sig selv bevis for opfyldte acceptkriterier.
5. Hvilke produktændringer eller nye backlogopgaver giver gennemgangen anledning til?

Noter fra mødet:
- Demonstreret resultat:
- Opfyldte acceptkriterier og grundlag:
- Mangler og opfølgning:
- Produktbeslutninger:

## Retrospective om arbejdsprocessen

1. Hvad har hjulpet med at bevare overblik og motivation?
2. Hvad blev for hurtigt eller svært at forstå?
3. Hvordan fungerede pauser, håndskrevet board og dokumentation?
4. Hvordan fungerede AI-støtten, og hvor skal den studerende have mere tænketid eller selv forklare løsningen?
5. Vælg højst to konkrete forbedringer til næste sprint.

Emner fra dialogen: små trin, Ctrl + F med præcis søgetekst, visuelle plan/statuslinjer og forståelsesstop efter delmål. Disse er input til refleksion, ikke et allerede gennemført retrospective.

Noter fra mødet:
- Det fungerede:
- Det var vanskeligt:
- Valgte forbedringer:
- Hvordan vi følger op:

## Fælles Definition of Done

Forslag til drøftelse, ikke en efterfølgende påstand om tidligere arbejde:
- Opgavens acceptkriterier er gennemgået, og aftalt funktionalitet virker.
- Relevant afprøvning er gennemført, og resultater samt kendte mangler er beskrevet.
- Koden kan bygges, og relevante automatiske kontroller består.
- Den studerende kan forklare formålet og sammenhængen i de væsentlige ændringer.
- Ændringerne er gennemgået og merged gennem en PR med tilknyttet opgave.
- Board og nødvendig dokumentation er ajour.

Beslutning ved mødet:
- Vedtaget Definition of Done:
- Hvordan mangler på tidligere opgaver håndteres:

## Sprint 2 planlægning

Forslag til mål: Borgeren kan se sine anmodninger, og borger samt administrator kan gennemføre et simuleret forløb med rollebaseret adgang og fælles visning af status.

- Backlogkandidater: PB04 Mine anmodninger, PB05 Simuleret login, PB06 Administration samt aftalt opfølgning fra review.
- Aftal faktisk startdato og afslutning onsdag 21. oktober 2026. Den oprindelige plan bevares som sammenligningsgrundlag.
- Afklar hvordan anmodninger i hukommelsen skal deles mellem sider og brugerforløb. En scoped service i Interactive Server deles ikke automatisk mellem forskellige forbindelser; navigation, genindlæsning og skift mellem borger/admin skal afprøves konkret.
- Vælg første lille opgave og relevante forståelsesstop.
- Bevar torsdag 22. oktober som buffer og forberedelse til aflevering fredag 23. oktober inden kl. 12.

Noter fra mødet:
- Faktisk sprintperiode:
- Aftalt sprintmål:
- Valgte opgaver og rækkefølge:
- Risici og afgrænsning:
- Første konkrete skridt:

## Afslutning af mødet

- Faktisk dato og tidspunkt:
- Den studerendes vigtigste beslutninger:
- AI-feedback og hvordan den blev anvendt:
- Næste aftalte status eller møde:

Efter mødet føres en kort opsummering i Scrum-moeder.md. Denne kladde bevares som forberedelse og markeres med henvisning til referatet. Dokumentationens commit og push aftales som et selvstændigt trin; denne fil er kun oprettet lokalt.

## Opfølgning

Mødet er gennemført i chatten 17. oktober 2026. Se referatet i Scrum-moeder.md. Kladdens forslag ovenfor bevares som forberedelsesmateriale; referatet angiver de faktisk vedtagne beslutninger.
