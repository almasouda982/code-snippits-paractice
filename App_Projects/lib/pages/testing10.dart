import 'package:firstwebapp/pages/dropDownMeth.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class testing10 extends StatefulWidget {
  const testing10({super.key});

  @override
  State<testing10> createState() => _testing10State();
}
class _testing10State extends State<testing10> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Drop Down Example'),
          backgroundColor: Colors.blue,
        ),
      // body: DropDown(
      //   selecteValue: 'Test'
      //
      //   ,)

    );
  }
}

// return Scaffold(
// appBar: AppBar(
// backgroundColor: Colors.blue,
// title: const Text('Form Example3'),
// ),
// body: Padding(
// padding: const EdgeInsets.all(12.0),
// child: Form(child: Column(
// children: [
//
// MyTextFormField(name:"Username"),
// const SizedBox(
// height: 20,
// ),
// MyTextFormField(name: "Password"),
//
// ],
// ),
// ),
// ),
// );