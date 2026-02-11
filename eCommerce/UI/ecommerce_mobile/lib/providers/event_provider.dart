import 'package:ecommerce_mobile/model/events.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class EventProvider extends BaseProvider<Events> {
  EventProvider() : super("cartEvent");

  @override
  Events fromJson(dynamic json) {
    return Events.fromJson(json);
  }
}
