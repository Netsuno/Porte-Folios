      ******************************************************************
      * Author: Marc-Andre Giroux
      * Date: 2021-05-11
      * Purpose: Demo technique utilisation d'un fichier text pour acquérir des valeurs.
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. FILECHECK.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT IN-FILE ASSIGN TO "Vaccin.txt"
               ORGANIZATION IS LINE SEQUENTIAL.

       DATA DIVISION.
       FILE SECTION.
       FD IN-FILE.
       01 IN-INFO.
           05 NOM-VACCIN   PIC X(16).
           05 NBR-AMUNE    PIC 9(8).
           05 NBR-ANE      PIC 9(8).
           05 NBR-COM      PIC 9(8).

       WORKING-STORAGE SECTION.

       01 SWITCHES.
           05 EOF-SWITCH       PIC X(1) VALUE "N".

       01 COUNTERS.
           05 REC-COUNTER      PIC 9(3) VALUE 0.

       PROCEDURE DIVISION.
       000-MAIN.
           PERFORM 100-INITIALIZE.
           PERFORM 200-PROCESS-RECORDS
               UNTIL EOF-SWITCH = "Y".
           PERFORM 300-FIN.
           STOP RUN.

       100-INITIALIZE.

           OPEN INPUT IN-FILE.

           READ IN-FILE
               AT END
                   MOVE "Y" TO EOF-SWITCH
               NOT AT END
                   COMPUTE REC-COUNTER = REC-COUNTER + 1
               END-READ.

       200-PROCESS-RECORDS.

           DISPLAY "Nom du Vaccin:" NOM-VACCIN.
           DISPLAY "Nombre avec une dose: " NBR-ANE.
           DISPLAY "Nombre avec 2 doses: " NBR-COM.
           DISPLAY "Total: " NBR-AMUNE.

           READ IN-FILE
               AT END
                   MOVE "Y" TO EOF-SWITCH
               NOT AT END
                   COMPUTE REC-COUNTER = REC-COUNTER + 1
               END-READ.

       300-FIN.
           DISPLAY "Nombre de marque de Vaccin " REC-COUNTER
           CLOSE IN-FILE.

       END PROGRAM FILECHECK.
