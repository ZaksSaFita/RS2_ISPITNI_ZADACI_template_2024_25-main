import 'dart:math';

import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/user_activity.dart';
import 'package:ecommerce_mobile/providers/activity_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/frmNewActivityBrojIndeksa.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class UserActivityScreen extends StatefulWidget {
  const UserActivityScreen({super.key});

  @override
  State<UserActivityScreen> createState() => _UserActivityScreen();
}

class _UserActivityScreen extends State<UserActivityScreen> {
  late ActivityProvider activityProvider;
  SearchResult<UserActivity>? data;
  int points = 0;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    activityProvider = ActivityProvider();
    loadData(null);
  }

  loadData(String? status) async {
    points = 0;
    data = await activityProvider.get(filter: {"status": status});
    for (var element in data!.items!) {
      print("${element.id}");
      points += element.numberOfPoints;
    }
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Activity List",
      child: Center(
        child: Column(
          children: [_buildSearch(), _buildResultView(), _buildSummary()],
        ),
      ),
    );
  }

  Widget _buildSummary() {
    return Container(
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.grey[100],
        border: Border(top: BorderSide(color: Colors.grey[300]!)),
      ),
      child: Column(
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Text(
                "Total Points: ",
                style: TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                ),
              ),
              Text(
                "$points",
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                  color: Colors.green,
                ),
              ),
            ],
          ),
        ],
      ),
    );
  }

  List<String> statusState = [
    "All",
    "Assigned",
    "InProgress",
    "Completed",
    "Cancelled"
  ];
  String? selectedStatus;

  Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Expanded(
              child: DropdownButtonFormField(
                  hint: Text("Select Status"),
                  items: statusState
                      .map((e) => DropdownMenuItem(value: e, child: Text(e)))
                      .toList(),
                  onChanged: (value) async {
                    selectedStatus = value;
                    if (selectedStatus == "All") {
                      selectedStatus = null;
                    }
                    loadData(selectedStatus);
                    print("Status: $selectedStatus");
                  }),
            ),
            SizedBox(
              width: 1000,
            ),
            Expanded(
                child: ElevatedButton.icon(
              onPressed: () {
                Navigator.of(context).push(MaterialPageRoute(
                    builder: (context) => NewActivityScreen()));
              },
              label: Text("Add Activity"),
              icon: Icon(Icons.local_activity_rounded),
            ))
          ],
        ));
  }

  Widget _buildResultView() {
    if (data == null || data!.items!.isEmpty) {
      return Center(
        child: Row(
          children: [Text("loading data ..."), CircularProgressIndicator()],
        ),
      );
    }
    return Expanded(
      child: Container(
        width: double.infinity,
        padding: EdgeInsets.all(20),
        child: SingleChildScrollView(
          child: DataTable(
              columns: const [
                DataColumn(label: Text("Name")),
                DataColumn(label: Text("Activity")),
                DataColumn(label: Text("Status")),
                DataColumn(label: Text("Due Date"))
              ],
              rows: data!.items!
                      .map((e) => DataRow(cells: [
                            DataCell(Text(
                                "${e.user?.firstName} ${e.user?.lastName}")),
                            DataCell(Text("${e.activityBrojIndeksa?.name}")),
                            DataCell(Text(e.status)),
                            DataCell(Text(DateFormat("dd-MM-yyyy")
                                .format(e.activityBrojIndeksa!.dueDate!)))
                          ]))
                      .toList() ??
                  []),
        ),
      ),
    );
  }

  List<Widget> _buildProductCardList() {
    if (data == null || data!.items!.isEmpty) {
      return [Text("No data ...")];
    }

    List<Widget> list = data!.items!
        .map((x) => Container(
              decoration: BoxDecoration(border: Border.all()),
              child: Column(
                children: [
                  Expanded(
                    child: Column(
                      children: [
                        Text("Name: ",
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text(
                          "${x.user?.firstName} ${x.user?.lastName}",
                          style: TextStyle(color: Colors.red),
                        ),
                      ],
                    ),
                  ),
                  Expanded(
                    child: Column(
                      children: [
                        Text(
                          "Activity: ",
                          style: TextStyle(fontWeight: FontWeight.bold),
                        ),
                        Text(x.activityBrojIndeksa!.name,
                            style: TextStyle(color: Colors.red)),
                      ],
                    ),
                  ),
                  Expanded(
                    child: Column(
                      children: [
                        Text("Status: ",
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text(x.status, style: TextStyle(color: Colors.red)),
                      ],
                    ),
                  ),
                  Expanded(
                    child: Column(
                      children: [
                        Text("Due Date: ",
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text(
                            DateFormat("dd-MM-yyyy")
                                .format(x.activityBrojIndeksa!.dueDate!),
                            style: TextStyle(color: Colors.red)),
                      ],
                    ),
                  ),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
