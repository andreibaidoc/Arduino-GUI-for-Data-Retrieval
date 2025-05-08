#define ARDUINO_LED 13

String data;
char dl;

void setup() {
  Serial.begin(9600);             // initialize a serial port
  pinMode(ARDUINO_LED, OUTPUT);   // turn on own Arduino's LED

  // wait until the PC side actually opens the port…
  while (!Serial) {
    ;  // do nothing
  }

  // ...then blink the LED 3x to signal you're connected
  for (int i = 0; i < 3; i++) {
    digitalWrite(ARDUINO_LED, HIGH);
    delay(200);
    digitalWrite(ARDUINO_LED, LOW);
    delay(200);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()) {
    data = Serial.readString();
    dl = data.charAt(0);

    switch(dl) {
      case 'A': digitalWrite(13, HIGH); break;
      case 'a': digitalWrite(13, LOW); break;
    }
  }
}
