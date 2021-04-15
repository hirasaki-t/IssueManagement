import { Meta, Story } from "@storybook/react/types-6-0";
import Drawers from "../components/Drawers";

export default {
    title: "components/Drawers",
    components: Drawers,
} as Meta;

const Template: Story = () => <Drawers />;

export const Default = Template.bind({});