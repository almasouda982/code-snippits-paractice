import 'package:firstwebapp/pages/testing.dart';
import 'package:firstwebapp/pages/testing10.dart';
import 'package:firstwebapp/pages/testing2.dart';
import 'package:firstwebapp/pages/testing3.dart';
import 'package:firstwebapp/pages/testing4.dart';
import 'package:firstwebapp/pages/testing9.dart';
import 'package:firstwebapp/proj/loginScreen3.dart';
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
      home: Loginscreen3(),
      debugShowCheckedModeBanner: false,

    );
  }
}



