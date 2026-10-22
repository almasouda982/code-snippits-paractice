import 'package:flutter/material.dart';

class testing6 extends StatefulWidget {
  const testing6({super.key});

  @override
  State<testing6> createState() => _testing6State();
}

class _testing6State extends State<testing6> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Row and Col"),
        backgroundColor: Colors.blue,

      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Column(),
          Text("Row:"),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Icon(Icons.person),
              Icon(Icons.apple),
              Icon(Icons.app_blocking),
              Icon(Icons.ad_units),

            ],
          )
        ],
      ),
    );
  }
}
