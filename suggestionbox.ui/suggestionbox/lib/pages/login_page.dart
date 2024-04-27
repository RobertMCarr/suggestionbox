import 'package:flutter/material.dart';
import 'package:suggestionbox/components/my_text_box.dart';
import 'package:suggestionbox/components/my_button.dart';
import 'package:suggestionbox/components/square_tile.dart';
import 'package:supabase_flutter/supabase_flutter.dart';

class LoginPage extends StatelessWidget {
  LoginPage({super.key});

  // text editing controllers
  final usernameController = TextEditingController();
  final passwordController = TextEditingController();

  void showLoginDialog(BuildContext context) async {
     AlertDialog alert = AlertDialog(
          title: const Text('Login Unsuccessful'),
          content: const Text('Please try again.'),
          actions: <Widget>[
            TextButton(
              onPressed: () => Navigator.of(context).pop(),
              child:  const Text("OK"),
            ),
          ],
          //elevation: 24.0,
          //backgroundColor: Colors.blue,
        );  

        // show the dialog
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return alert;
      },
      barrierDismissible: true,
    );
  }

  //sign in method with email and password
  Future<void> signInWithEmail(BuildContext context) async {
    try {
      await Supabase.instance.client.auth.signInWithPassword(
        email: usernameController.text,
        password: passwordController.text
      );
    } catch(e) {
      showLoginDialog(context);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.grey[300],
      body: SafeArea(
        child: Center(
          child: SingleChildScrollView(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                const SizedBox(height: 50),
            
                // logo
                const Icon(
                  Icons.lock,
                  size: 100,
                ),
            
                const SizedBox(height: 50),
                // welcome back text
                Text(
                  'Welcome back you\'ve been missed',
                  style: TextStyle(
                    color: Colors.grey[700],
                    fontSize: 16,
                  ),
                ),
            
                const SizedBox(height: 25),
            
                // username text field
                MyTextBox(
                  controller: usernameController,
                  hintText: 'Username',
                  obscureText: false,
                ),
            
                // password text field
                const SizedBox(height: 10),
            
                MyTextBox(
                  controller: passwordController,
                  hintText: 'Password',
                  obscureText: true,
                ),
            
                // forgot password?
                const SizedBox(height: 10),
            
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 25.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.end,
                    children: [
                      Text(
                        'Forgot Password?',
                        style: TextStyle(color: Colors.grey[600]),
                      ),
                    ],
                  ),
                ),
            
                const SizedBox(height: 25),
            
                // sign in button
                MyButton(
                  onTap: () => signInWithEmail(context),
                ),
            
                const SizedBox(height: 25),
            
                // or continue with
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 25.0),
                  child: Row(
                    children: [
                      Expanded(
                        child: Divider(
                          thickness: 0.5,
                          color: Colors.grey[400],
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 10.0),
                        child: Text(
                          'Or continue with',
                          style: TextStyle(color: Colors.grey[700]),
                        ),
                      ),
                      Expanded(
                        child: Divider(
                          thickness: 0.5,
                          color: Colors.grey[400],
                        ),
                      ),
                    ],
                  ),
                ),
            
                // Google + apple signin buttons
                const SizedBox(height: 50),
            
                const Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    // Google Tile
                    SquareTile(imagePath: 'lib/images/google.png'),
            
                    SizedBox(width: 25),
            
                    // Apple Tile
                    SquareTile(imagePath: 'lib/images/apple.png')
                  ]
                ),
            
                // not a member? register now
                const SizedBox(height: 50),
            
                Row( 
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text(
                      'Not a Member?',
                      style: TextStyle(color: Colors.grey[700])
                    ),
                    const SizedBox(width: 4),
                    const Text(
                      'Register Now',
                      style: TextStyle(
                        color: Colors.blue,
                        fontWeight: FontWeight.bold
                      ),
                    )
                  ],
                )
              ],
            ),
          ),
        )
      )
    );
  }
}
