import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/events.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/event_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class EventScreen extends StatefulWidget {
  const EventScreen({super.key});

  @override
  State<EventScreen> createState() => _EventScreen();
}

class _EventScreen extends State<EventScreen> {
  late EventProvider eventProvider;
  TextEditingController searchController = TextEditingController();

  SearchResult<Events>? events;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    eventProvider = EventProvider();
    loadData(null, null);
  }

  List<String> eventTypes = [
    "All",
    "Add",
    "Update",
    "Delete",
    "Clear",
    "CheckOut"
  ];
  String? selectedEvent;

  loadData(String? username, String? selectedEvent) async {
    var result = await eventProvider
        .get(filter: {"username": username, "fts": selectedEvent});

    events = result;

    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Event List",
      child: Center(
        child: Column(
          children: [_buildSearch(), _buildResultView()],
        ),
      ),
    );
  }

  Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          children: [
            Expanded(
              child: TextField(
                onChanged: (value) {
                  loadData(value, selectedEvent);
                },
                decoration: InputDecoration(
                  hintText: "Search",
                  border: OutlineInputBorder(),
                ),
                controller: searchController,
              ),
            ),
            SizedBox(
              width: 30,
            ),
            Expanded(
                child: DropdownButtonFormField(
                    initialValue: selectedEvent,
                    hint: Text("Select event"),
                    items: eventTypes
                            .map((e) =>
                                DropdownMenuItem(value: e, child: Text(e)))
                            .toList() ??
                        [],
                    onChanged: (value) async {
                      selectedEvent = value as String?;
                      if (selectedEvent == "All") {
                        selectedEvent = null;
                      }
                      print(selectedEvent);
                      loadData(searchController.text, selectedEvent);
                    }))
          ],
        ));
  }

  Widget _buildResultView() {
    if (events?.items == null || events!.items!.isEmpty) {
      return Center(
        child: Text("No events found"),
      );
    }
    return Expanded(
        child: Container(
      width: double.infinity,
      child: SingleChildScrollView(
        child: DataTable(
          columns: [
            DataColumn(label: Text("User")),
            DataColumn(label: Text("Cart")),
            DataColumn(label: Text("Product")),
            DataColumn(label: Text("Type")),
            DataColumn(label: Text("Date")),
          ],
          rows: events?.items
                  ?.map((e) => DataRow(cells: [
                        DataCell(Text(e.userFullName)),
                        DataCell(Text(e.cartId.toString())),
                        DataCell(Text(e.productName)),
                        DataCell(Text(e.eventType)),
                        DataCell(Text(
                            DateFormat("dd-MM-yyyy").format(e.createdAt!))),
                      ]))
                  .toList() ??
              [],
        ),
      ),
    ));
  }
}
