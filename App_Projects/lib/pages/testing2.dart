import 'package:flutter/material.dart';

class Testing2 extends StatefulWidget {
  const Testing2({super.key});

  @override
  State<Testing2> createState() => _Testing2State();
}

class _Testing2State extends State<Testing2> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Text Example"),
      ),
      body: Center(
        child: Text("Welcome",
        style: TextStyle(
          fontSize: 40,
          color: Colors.blueAccent,
          fontWeight: FontWeight.bold,
        ),),
      ),
    );
  }
}
