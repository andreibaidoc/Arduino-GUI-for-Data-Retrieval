#define RED_LED 3

String data, x;
char dl;
int ledval;

void HandlePot() {
  String val;
  static int old = 0;
  int current = 0, upper, lower;
  current = analogRead(A0);
  upper = current + 2;
  lower = current - 2;
  if(current != old) {
    if((old <= lower) || (old >= upper)) {
      val = String(current);
      Serial.print("v");
      Serial.println(val);
      old = current;
    }
  }
}

void setup() {
  Serial.begin(9600);   // initialize a serial port
  pinMode(13, OUTPUT);  // turn on own Arduino's LED
  pinMode(RED_LED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()) {
    data = Serial.readString();
    dl = data.charAt(0);

    switch(dl) {
      case 'A': digitalWrite(13, HIGH); break;
      case 'a': digitalWrite(13, LOW); break;
      case 'R': 
        x = data.substring(1);
        ledval = x.toInt();
        analogWrite(3, ledval);
        break;
    }
  }

  // Potentiometer handle
  HandlePot();
}
