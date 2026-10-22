import 'package:flutter/material.dart';

import 'myTextFormExamplePage.dart';

class testing9 extends StatefulWidget {
  const testing9({super.key});

  @override
  State<testing9> createState() => _testing9State();
}

class _testing9State extends State<testing9> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      // appBar: AppBar(
      //   backgroundColor: Colors.blue,
      //   title: const Text("Form Example")
      // ),
      // body: Padding(
      //     padding: const EdgeInsets.all(12.0),
      //   child: Form(child: Column(
      //     children: [
      //       TextFormField(
      //         decoration: InputDecoration(
      //           labelText: "Username",
      //           enabledBorder: OutlineInputBorder(
      //             borderSide: BorderSide(
      //               color: Colors.green,
      //               width: 1,
      //             ),
      //             borderRadius: BorderRadius.all(Radius.circular(20))
      //           )
      //         ),
      //         validator: (value){
      //          
      //         },
      //       )
      //     ],
      //   ),),
      // ),
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text("Form Example"),
      ),
      body: Padding(
          padding: const EdgeInsets.all(12.0),
      child: Form(child: Column(
        children: [

          TextFormExample(name: "Username"),
          const SizedBox(
            height: 20,
          ),
          TextFormExample(name: "Password"),
          const SizedBox(
            height: 20,
          )
        ],
      )),),
    );
  }
}
