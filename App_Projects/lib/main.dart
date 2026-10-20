import 'package:flutter/material.dart';

import '0.scaffoldexample.dart';
import '0.pageexample.dart';
import 'excersise.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(

        colorScheme: .fromSeed(seedColor: Colors.deepPurple),
      ),
      home: excersise(),
      debugShowCheckedModeBanner: false,

    );
  }
}



