import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/user_activity.dart';
import 'package:ecommerce_mobile/providers/activity_provider.dart';
import 'package:ecommerce_mobile/screens/frmActivitiesBrojIndeksa.dart';
import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class NewActivityScreen extends StatefulWidget {
  const NewActivityScreen({super.key});

  @override
  State<NewActivityScreen> createState() => _NewActivityScreen();
}

class _NewActivityScreen extends State<NewActivityScreen> {
  final formKey = GlobalKey<FormBuilderState>();

  bool isLoading = true;

  late ActivityProvider activityProvider;

  SearchResult<UserActivity>? data;
  List activities = [];
  int selectedAckivnost = 0;
  List korisnici = [];
  int selectedKorisnik = 0;
  String? note;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    activityProvider = ActivityProvider();
    loadData();
  }

  loadData() async {
    data = await activityProvider.get();

    for (var item in data!.items!) {
      var activity = item.activityBrojIndeksa;
      var korisnik = item.user;
      bool postoji = activities.any((e) => e.id == activity!.id);
      bool postojiKorisnik = korisnici.any((e) => e.id == korisnik!.id);
      if (!postoji) {
        activities.add(activity);
      }
      if (!postojiKorisnik) {
        korisnici.add(korisnik);
      }
      print("akt: ${activity!.name}");
    }
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Add Activity",
      child: Center(
        child: Column(
          children: [_buildForm(), _buildSaveButton()],
        ),
      ),
    );
  }

  Widget _buildForm() {
    return FormBuilder(
        key: formKey,
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            children: [
              Row(
                children: [
                  Expanded(
                      child: FormBuilderDropdown(
                    onChanged: (value) {
                      selectedKorisnik = value as int;
                      print("$selectedKorisnik");
                      setState(() {});
                    },
                    name: "userId",
                    decoration: InputDecoration(labelText: "Users"),
                    items: korisnici
                            .map((e) => DropdownMenuItem(
                                value: e.id,
                                child: Text("${e.firstName} ${e.lastName}")))
                            .toList() ??
                        [],
                  )),
                  SizedBox(
                    width: 30,
                  ),
                  Expanded(
                      child: FormBuilderDropdown(
                    onChanged: (value) {
                      selectedAckivnost = value as int;
                      print("$selectedAckivnost");
                      setState(() {});
                    },
                    name: "activityBrojIndeksaId",
                    decoration: InputDecoration(labelText: "Aktivnosti"),
                    items: activities
                            .map((e) => DropdownMenuItem(
                                value: e.id, child: Text(e.name)))
                            .toList() ??
                        [],
                  )),
                ],
              ),
              FormBuilderTextField(
                name: "note",
                decoration: InputDecoration(labelText: "Note"),
                onChanged: (value) {
                  note = value.toString();
                  print("$note");

                  setState(() {});
                },
              ),
            ],
          ),
        ));
  }

  Widget _buildSaveButton() {
    return ElevatedButton(
      onPressed: () async {
        formKey.currentState?.saveAndValidate();
        if (formKey.currentState?.validate() ?? false) {
          print(formKey.currentState?.value.toString());
          var request = Map.from(formKey.currentState?.value ?? {});
          await activityProvider.insert(request).then((_) =>
              Navigator.of(context).push(MaterialPageRoute(
                  builder: (context) => UserActivityScreen())));
        }
      },
      child: Text("Save"),
    );
  }
}
